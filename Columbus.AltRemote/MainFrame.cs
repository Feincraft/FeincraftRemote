using Columbus.AltRemote.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Columbus.AltRemote
{
    public partial class MainFrame : Form
    {
        /* Constructors */
        #region Constructors
        /// <summary>
        /// Default constructors
        /// </summary>
        public MainFrame()
        {
            InitializeComponent();
        }
        #endregion

        /* Locals variables */
        #region Local variables
        Int32 resW = 0;
        Int32 resH = 0;
        Boolean noTextEvents = false;
        String currentUser = "";
        Boolean inet;
        List<SizePreview> frmPreview = new List<SizePreview>();
        Boolean preview = true;
        #endregion

        /* Local methods */
        #region Local methods

        /// <summary>
        /// Check for Internet connection
        /// </summary>
        /// <returns>True if connected</returns>
        public Boolean CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.microsoft.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Reads settings from fields and encodes\encrypts them in a Base64 string
        /// </summary>
        /// <returns>Encrypted Base64 settings</returns>
        private String EncodeSettings()
        {
            String returnValue;
            if (!Settings.Default.RememberPasswords) { txtPass.Text = ""; }
            String connection = String.Format("{0}@{1}", txtServer.Text, lstRes.Text);
            if (chkAdmin.Checked) { connection += "/a"; }
            if (chkScale.Checked) { connection += "/s"; }
            connection += String.Format("/n{2}/l{0}/p{1}", txtLogin.Text, txtPass.Text,txtLabel.Text);

            Byte[] bytes = new Byte[connection.Length * sizeof(Char)];
            Buffer.BlockCopy(connection.ToCharArray(), 0, bytes, 0, bytes.Length);
            bytes = ProtectedData.Protect(bytes, null, DataProtectionScope.CurrentUser);
            
            returnValue = Convert.ToBase64String(bytes);

            return returnValue;
        }

        /// <summary>
        /// Decodes\decrypts Base64 settings
        /// </summary>
        /// <param name="code">String to decrypt</param>
        /// <returns>Settings string</returns>
        private String DecodeSettings(String code)
        {
            String returnValue;

            Byte[] bytes = Convert.FromBase64String(code);
            bytes = ProtectedData.Unprotect(bytes, null, DataProtectionScope.CurrentUser);
            Char[] chars = new Char[bytes.Length / sizeof(Char)];
            Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);

            returnValue = new String(chars);
            return returnValue;
        }

        /// <summary>
        /// Adds or updates current connection
        /// </summary>
        private void AddToRecent()
        {
            String key = txtServer.Text + txtLogin.Text + lstRes.Text;
            String settings = EncodeSettings();

            if (lstRecent.Items.ContainsKey(key))
            {
                // Update recent
                lstRecent.Items[key].Tag = settings;
            }
            else
            {
                // Add recent to list
                ListViewItem item = new ListViewItem
                {
                    Name = key,
                    Text = txtLabel.Text,
                    Tag = settings
                };
                item.SubItems.Add(txtServer.Text);
                item.SubItems.Add(txtLogin.Text);
                item.SubItems.Add(lstRes.Text);
                lstRecent.Items.Insert(0, item);
            }
        }

        /// <summary>
        /// Saves all recent connections
        /// </summary>
        private void SaveRecent()
        {
            String key = txtServer.Text + txtLogin.Text + lstRes.Text;
            String settings = EncodeSettings();

            // Save in all recent
            String code = "";
            foreach (ListViewItem oneItem in lstRecent.Items)
            {
                code += oneItem.Tag.ToString() + "|";
            }

            Settings.Default.Recent = code;
            Settings.Default.Save();
        }

        /// <summary>
        /// Loads all recent connections
        /// </summary>
        private void LoadRecent()
        {
            try
            {
                lstRecent.Items.Clear();
                if (Settings.Default.Recent == "") return;
                foreach (String oneLine in Settings.Default.Recent.Split('|'))
                {
                    String code = oneLine.Replace("|", "");
                    if (code == "") { break; }
                    ListViewItem oneItem = new ListViewItem();

                    String settings = DecodeSettings(code);
                    // Label
                    String arg = settings.Substring(settings.IndexOf("/n") + 2);
                    oneItem.Text = arg.Remove(arg.IndexOf("/"));
                    
                    // Server
                    oneItem.SubItems.Add(settings.Remove(settings.IndexOf('@')));

                    // Login
                    arg = settings.Substring(settings.IndexOf("/l") + 2);
                    arg = arg.Remove(arg.IndexOf("/p"));
                    oneItem.SubItems.Add(arg);

                    // Resolution
                    arg = settings.Substring(settings.IndexOf('@') + 1);
                    arg = arg.Remove(arg.IndexOf('/'));
                    oneItem.SubItems.Add(arg);

                    // Code
                    oneItem.Tag = code;

                    // Key
                    oneItem.Name = oneItem.SubItems[1].Text + oneItem.SubItems[2].Text + oneItem.SubItems[3].Text;

                    lstRecent.Items.Add(oneItem);
                }
            }
            catch { }
        }

        /// <summary>
        /// Sets form UI control settings
        /// </summary>
        private void SetUiSettings()
        {
            if (Settings.Default.UseGPU)
            { this.Text = Settings.Default.Title + " (GPU Accelerated)"; }
            else { this.Text = Settings.Default.Title; }

            txtPass.Enabled = Settings.Default.RememberPasswords;
        }

        /// <summary>
        /// Start update process
        /// </summary>
        private void StartUpdate()
        {
            Process update = new Process();
            update.StartInfo.FileName = Settings.Default.ReleaseUrl;
            update.Start();
        }
        #endregion

        /* Event handlers */
        #region Event handlers
        private void btnConnect_Click(object sender, EventArgs e)
        {
            // Validate fields 
            txtServer_Validating(new Object(), new CancelEventArgs());
            lstRes_Validating(new Object(), new CancelEventArgs());
            if (!(errRes.GetError(lstRes) == "" && errServer.GetError(txtServer) == ""))
            { return; }

            this.Enabled = false;
            btnConnect.Text = "Connecting...";
            Application.DoEvents();

            // Save in recent
            if (Settings.Default.RememberRecent)
            {
                AddToRecent();
                SaveRecent();
            }

            // Create template instance
            String thisPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            String templatePath = Path.Combine(thisPath, "Template");
            String tempFile = Path.GetTempFileName();
            
            File.Copy(templatePath, tempFile, true);

            // Prepare template copy
            StreamReader fIn = new StreamReader(tempFile);
            String tempCopy = fIn.ReadToEnd();
            fIn.Close();

            // Screen mode
            if (lstRes.Text == "Full Screen")
            { tempCopy = tempCopy.Replace("$ScreenMode", "2"); }
            else { tempCopy = tempCopy.Replace("$ScreenMode", "1"); }

            // GPU mode
            if (Settings.Default.UseGPU)
            { tempCopy = tempCopy.Replace("$Gpu", "1"); }
            else { tempCopy = tempCopy.Replace("$Gpu", "0"); }

            // Define resolution
            tempCopy = tempCopy.Replace("$Width", resW.ToString());
            tempCopy = tempCopy.Replace("$Height", resH.ToString());

            // Server address
            tempCopy = tempCopy.Replace("$Address", txtServer.Text);

            // Scaling enabled
            if (chkScale.Checked)
            { tempCopy = tempCopy.Replace("$Scale", "1"); }
            else { tempCopy = tempCopy.Replace("$Scale", "0"); }

            // Save template
            StreamWriter fOut = new StreamWriter(tempFile);
            fOut.Write(tempCopy);
            fOut.Close();

            // Write credentials
            String args;
            Process rdcProcess = new Process();
            if ((txtLogin.Text != "" && txtPass.Text != "") || (txtLogin.Text != "" && txtPass.Text == ""))
            {
                args = "/generic:TERMSRV/{0} /user:{1}";
                if (txtPass.Text != "") { args += " /pass:{2}"; }
                rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe");
                rdcProcess.StartInfo.Arguments = String.Format(args, txtServer.Text, txtLogin.Text, txtPass.Text);
                rdcProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                rdcProcess.Start();
                rdcProcess.WaitForExit();
                Thread.Sleep(1000);
            }

            // Start session
            args = String.Format(@"""{0}"" ", tempFile);
            if (chkAdmin.Checked) args += "/admin ";
            if (lstRes.Text == "Full Screen") args += "/f ";
            
            rdcProcess = new Process();
            rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\mstsc.exe");
            rdcProcess.StartInfo.Arguments = args;
            rdcProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            rdcProcess.Start();

            // Delayed credentials removal thread
            BackgroundWorker threadForgetCred = new BackgroundWorker();
            String serverName = txtServer.Text;
            threadForgetCred.DoWork += delegate(Object a, DoWorkEventArgs b) 
            {
                Thread.Sleep(10000);
                // Forget credentials
                rdcProcess = new Process();
                rdcProcess.StartInfo.FileName = Environment.ExpandEnvironmentVariables(@"%SystemRoot%\system32\cmdkey.exe");
                rdcProcess.StartInfo.Arguments = String.Format("/delete:TERMSRV/{0}", serverName);
                rdcProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                rdcProcess.Start();
                rdcProcess.WaitForExit();

                // Remove template
                File.Delete(tempFile);
            };
            threadForgetCred.RunWorkerAsync();

            this.Enabled = true;
            btnConnect.Text = "Connect";
        }

        private void lstRecent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstRecent_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected)
            {
                lnkRemove.Enabled = false;
                return;
            }
            lnkRemove.Enabled = true;

            // Read settings
            String settings = DecodeSettings(e.Item.Tag.ToString());
            Int32 passPos = settings.IndexOf("/p") + 2;
            if (passPos < settings.Length)
            {
                txtServer.Text = settings.Remove(passPos);
                txtPass.Text = settings.Substring(passPos);
            }
            else { txtServer.Text = settings; }

            preview = false;
            txtServer_Validating(new Object(), new CancelEventArgs());
        }

        private void lstRecent_ItemActivate(object sender, EventArgs e)
        {
            btnConnect_Click(new Object(), new EventArgs());
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            // Insert optimized resolution
            Size workArea = Screen.GetWorkingArea(this).Size;
            lstRes.Items.Insert(0, String.Format("{0}x{1}", workArea.Width - 7, workArea.Height - 30));

            // Setup preview
            for (Int32 x = 0; x < 4; x++)
            {
                frmPreview.Add(new SizePreview());
                frmPreview[x].Show(this);
            }
            frmPreview[0].Height = 5;
            frmPreview[1].Height = 5;
            frmPreview[2].Width = 5;
            frmPreview[3].Width = 5;
            frmPreview[3].Top = 6;

            // Get current user
            lblLogged.Text = String.Format("Logged on as {0}\\{1}", Environment.UserDomainName, Environment.UserName);

            // Load recent list
            LoadRecent();

            // Set title
            SetUiSettings();
            return;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings.Default.Recent = "";
            Settings.Default.Save();
            lstRecent.Items.Clear();
        }

        private void lnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lstRecent.SelectedItems[0].Remove();
            SaveRecent();
        }

        private void tmrConnect_Tick(object sender, EventArgs e)
        {
            tmrConnect.Enabled = false;
            BackgroundWorker threadLogin = new BackgroundWorker();
            threadLogin.DoWork += delegate(Object a, DoWorkEventArgs b)
            {
                try
                {
                    currentUser = String.Format("Logged on as {0}", UserPrincipal.Current.DisplayName);
                }
                catch { }
                inet = CheckForInternetConnection();
            };
            threadLogin.RunWorkerCompleted += delegate(object a, RunWorkerCompletedEventArgs b)
            {
                if (inet)
                { lblConnect.Text = "Connected to the Internet "; }
                else { lblConnect.Text = "No Internet connection "; }

                if (currentUser == "")
                {
                    lblConnect.Text += "via External network";
                }
                else
                {
                    lblConnect.Text += "via Corporate network";
                    lblLogged.Text = currentUser;
                }
                tmrConnect.Enabled = true;
            };

            threadLogin.RunWorkerAsync();
        }

        private void txtServer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) { btnConnect_Click(new Object(), new EventArgs()); }
        }
        
        private void txtServer_Enter(object sender, EventArgs e)
        {
            errInfo.SetError(
                txtServer,
                @"Enter server name or IP" + Environment.NewLine +
                 "For quick connect, use the following format:" + Environment.NewLine +
                 "[server]@[width]x[height][/a][/s]/n[label]/l[login]/p[password]");
        }

        private void txtServer_Leave(object sender, EventArgs e)
        {
            errInfo.Clear();
        }

        private void txtServer_TextChanged(object sender, EventArgs e)
        {
            if (noTextEvents) return;
            if (txtServer.Text.Contains("/p"))
            {
                // Check password
                Int32 passPos = txtServer.Text.IndexOf("/p") + 2;
                if (passPos == txtServer.Text.Length)
                {
                    txtServer.Tag = null;
                    txtPass.Text = "";
                }
                if (passPos < txtServer.Text.Length)
                {
                    String pass = (String)txtServer.Tag;
                    pass += txtServer.Text[txtServer.Text.Length - 1];
                    txtServer.Tag = pass;
                    txtPass.Text = pass;

                    noTextEvents = true;
                    Int32 sPos = txtServer.SelectionStart;
                    txtServer.Text = txtServer.Text.Remove(txtServer.Text.Length - 1);
                    txtServer.SelectionStart = sPos;
                    noTextEvents = false;
                }
            }

        }

        private void txtServer_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                errServer.Clear();
                txtServer.BackColor = Color.White;

                if (txtServer.Text.Contains("/"))
                {
                    // Admin 
                    chkAdmin.Checked = txtServer.Text.Contains("/a");

                    // Scale 
                    chkScale.Checked = txtServer.Text.Contains("/s");
                }

                // Label
                if (txtServer.Text.Contains("/n"))
                {
                    String label = txtServer.Text.Substring(txtServer.Text.IndexOf("/n") + 2);
                    if (label.Contains("/"))
                    { label = label.Remove(label.IndexOf("/")).Trim(); }
                    txtLabel.Text = label;
                }

                // Login
                if (txtServer.Text.Contains("/l"))
                {
                    String login = txtServer.Text.Substring(txtServer.Text.IndexOf("/l") + 2);
                    if (login.Contains("/"))
                    { login = login.Remove(login.IndexOf("/")).Trim(); }
                    txtLogin.Text = login;
                }

                // Resolution
                if (txtServer.Text.Contains("@"))
                {
                    String res = txtServer.Text.Substring(txtServer.Text.IndexOf("@") + 1);
                    if (res.Contains("/"))
                    { res = res.Remove(res.IndexOf("/")).Trim(); }
                    lstRes.Text = res;
                }

                // Clean args
                if (txtServer.Text.Contains("@"))
                { txtServer.Text = txtServer.Text.Remove(txtServer.Text.IndexOf('@')); }
                if (txtServer.Text.Contains("/"))
                { txtServer.Text = txtServer.Text.Remove(txtServer.Text.IndexOf('/')); }

                // Check if blank
                if (txtServer.Text == "") { throw new Exception(); }
            }
            catch
            {
                errServer.SetError(
                    txtServer,
                    "Enter server name or IP\n" +
                    "For quick connect, use the following format:\n" +
                    "[server]@[width]x[height]/l[login]/p[password]");
                txtServer.BackColor = Color.MistyRose;
            }
        }

        private void lstRes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstRes_Validating(object sender, CancelEventArgs e)
        {
            errRes.Clear();
            lstRes.BackColor = Color.White;
            Boolean cancel = false;

            if (lstRes.Text.Contains("x"))
            {
                String w = lstRes.Text.Remove(lstRes.Text.IndexOf("x"));
                String h = lstRes.Text.Substring(lstRes.Text.IndexOf("x") + 1);
                if (!(Int32.TryParse(w, out resW) && Int32.TryParse(h, out resH)))
                { cancel = true; }
            }
            else
            {
                if (lstRes.Text != "Full Screen")
                { cancel = true; }
            }

            if (cancel)
            {
                lstRes.BackColor = Color.MistyRose;
                errRes.SetError(lstRes, "Resolution should be given in the format of [width]x[height]");
            }
        }

        private void lstRes_TextChanged(object sender, EventArgs e)
        {
            Int32 tResW = 0, tResH = 0;
            // Check for valid resolution
            if (lstRes.Text.Contains("x"))
            {
                String w = lstRes.Text.Remove(lstRes.Text.IndexOf("x"));
                String h = lstRes.Text.Substring(lstRes.Text.IndexOf("x") + 1);
                Int32.TryParse(w, out tResW);
                Int32.TryParse(h, out tResH);
            }

            // Check Full Screen
            if (lstRes.Text == "Full Screen")
            {
                tResH = Screen.GetWorkingArea(this).Size.Height;
                tResW = Screen.GetWorkingArea(this).Size.Width;               
            }

            // Show canvas
            if ((tResW > 0) && (tResH > 0) && preview)
            {
                for (Int32 x = 0; x < 4; x++)
                { frmPreview[x].Opacity = 0.5; }
                // X2
                frmPreview[0].Width = tResW + 4;
                frmPreview[0].Top = tResH;
                // X1
                frmPreview[1].Width = tResW - 1;
                // Y2
                frmPreview[2].Height = tResH - 1;
                frmPreview[2].Left = tResW;
                // Y1
                frmPreview[3].Height = tResH - 6;
            }
            else
            {
                for (Int32 x = 0; x < 4; x++)
                { frmPreview[x].Opacity = 0; }
            }
        }

        private void lstRes_Enter(object sender, EventArgs e)
        {
            preview = true;
            lstRes_TextChanged(new Object(), new EventArgs());
        }

        private void lstRes_Leave(object sender, EventArgs e)
        {
            for (Int32 x = 0; x < 4; x++)
            { frmPreview[x].Opacity = 0; }
        }

        private void lnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StartUpdate();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Options opt = new Options();
            opt.ShowDialog(this);
            SetUiSettings();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StartUpdate();
        }

        private void MainFrame_Resize(object sender, EventArgs e)
        {
            Settings.Default.WindowHeight = this.Height;
            Settings.Default.WindowWidth = this.Width;
        }

        private void MainFrame_Shown(object sender, EventArgs e)
        {
            this.Height = Settings.Default.WindowHeight;
            this.Width = Settings.Default.WindowWidth;
        }
        #endregion
    }
}
