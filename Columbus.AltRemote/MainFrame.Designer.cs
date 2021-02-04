namespace Columbus.AltRemote
{
    partial class MainFrame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "CiaServer01",
            "CIA\\Fain",
            "1200x600",
            "ThisIsMyPass"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "CiaServer01",
            "CIA\\Director",
            "1200x600",
            "ThisIsMyPassweqww"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Area51AlienDisections",
            "Pentagon\\Obama",
            "1920x1080",
            "wrewer223"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "BatComputer",
            "WayneEnt\\iambatman",
            "666x999",
            "sd23455dawa"}, -1);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblConnect = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLogged = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lnkUpdate = new System.Windows.Forms.LinkLabel();
            this.btnUpdate = new System.Windows.Forms.PictureBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lstRes = new System.Windows.Forms.ComboBox();
            this.chkAdmin = new System.Windows.Forms.CheckBox();
            this.chkScale = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.errRes = new System.Windows.Forms.ErrorProvider(this.components);
            this.errServer = new System.Windows.Forms.ErrorProvider(this.components);
            this.lnkClear = new System.Windows.Forms.LinkLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lnkRemove = new System.Windows.Forms.LinkLabel();
            this.lstRecent = new System.Windows.Forms.ListView();
            this.ServerLabel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Server = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Resolution = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errConnect = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrConnect = new System.Windows.Forms.Timer(this.components);
            this.errInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errServer)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lblConnect);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 513);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(959, 48);
            this.panel1.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSettings);
            this.panel6.Controls.Add(this.btnConnect);
            this.panel6.Controls.Add(this.btnQuit);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(627, 7);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(332, 41);
            this.panel6.TabIndex = 47;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(121, 3);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(98, 25);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(17, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 25);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(226, 3);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(98, 25);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.ForeColor = System.Drawing.Color.White;
            this.lblConnect.Location = new System.Drawing.Point(15, 18);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(117, 13);
            this.lblConnect.TabIndex = 13;
            this.lblConnect.Text = "Checking connection...";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Columbus.AltRemote.Properties.Resources.Shadow;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(959, 7);
            this.panel3.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblLogged);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.imgLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 94);
            this.panel2.TabIndex = 46;
            // 
            // lblLogged
            // 
            this.lblLogged.AutoSize = true;
            this.lblLogged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogged.Location = new System.Drawing.Point(103, 48);
            this.lblLogged.Name = "lblLogged";
            this.lblLogged.Size = new System.Drawing.Size(201, 20);
            this.lblLogged.TabIndex = 2;
            this.lblLogged.Text = "Logged on as Ilya Fainberg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(101, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Feincraft Remote";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(27, 19);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(70, 68);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // lnkUpdate
            // 
            this.lnkUpdate.AutoSize = true;
            this.lnkUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkUpdate.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkUpdate.Location = new System.Drawing.Point(205, 273);
            this.lnkUpdate.Name = "lnkUpdate";
            this.lnkUpdate.Size = new System.Drawing.Size(42, 13);
            this.lnkUpdate.TabIndex = 64;
            this.lnkUpdate.TabStop = true;
            this.lnkUpdate.Text = "Update";
            this.lnkUpdate.Visible = false;
            this.lnkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdate_LinkClicked);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(190, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(24, 14);
            this.btnUpdate.TabIndex = 65;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(17, 79);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(228, 20);
            this.txtServer.TabIndex = 1;
            this.txtServer.TextChanged += new System.EventHandler(this.txtServer_TextChanged);
            this.txtServer.Enter += new System.EventHandler(this.txtServer_Enter);
            this.txtServer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyUp);
            this.txtServer.Leave += new System.EventHandler(this.txtServer_Leave);
            this.txtServer.Validating += new System.ComponentModel.CancelEventHandler(this.txtServer_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Server \\ Quick Connect:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(15, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Login:";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.Location = new System.Drawing.Point(18, 120);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(228, 20);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(15, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Password:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtPass.Location = new System.Drawing.Point(18, 160);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = 'l';
            this.txtPass.Size = new System.Drawing.Size(228, 20);
            this.txtPass.TabIndex = 3;
            this.txtPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(16, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Resolution (WxH):";
            // 
            // lstRes
            // 
            this.lstRes.FormattingEnabled = true;
            this.lstRes.Items.AddRange(new object[] {
            "800x600",
            "1024x768",
            "1366x768",
            "1280x800",
            "1920x1080",
            "Full Screen"});
            this.lstRes.Location = new System.Drawing.Point(19, 244);
            this.lstRes.Name = "lstRes";
            this.lstRes.Size = new System.Drawing.Size(228, 21);
            this.lstRes.TabIndex = 5;
            this.lstRes.SelectedIndexChanged += new System.EventHandler(this.lstRes_SelectedIndexChanged);
            this.lstRes.TextChanged += new System.EventHandler(this.lstRes_TextChanged);
            this.lstRes.Enter += new System.EventHandler(this.lstRes_Enter);
            this.lstRes.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtServer_KeyUp);
            this.lstRes.Leave += new System.EventHandler(this.lstRes_Leave);
            this.lstRes.Validating += new System.ComponentModel.CancelEventHandler(this.lstRes_Validating);
            // 
            // chkAdmin
            // 
            this.chkAdmin.AutoSize = true;
            this.chkAdmin.ForeColor = System.Drawing.Color.DimGray;
            this.chkAdmin.Location = new System.Drawing.Point(18, 188);
            this.chkAdmin.Name = "chkAdmin";
            this.chkAdmin.Size = new System.Drawing.Size(136, 17);
            this.chkAdmin.TabIndex = 4;
            this.chkAdmin.Text = "Log on as Administrator";
            this.chkAdmin.UseVisualStyleBackColor = true;
            // 
            // chkScale
            // 
            this.chkScale.AutoSize = true;
            this.chkScale.Checked = true;
            this.chkScale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkScale.ForeColor = System.Drawing.Color.DimGray;
            this.chkScale.Location = new System.Drawing.Point(19, 273);
            this.chkScale.Name = "chkScale";
            this.chkScale.Size = new System.Drawing.Size(130, 17);
            this.chkScale.TabIndex = 6;
            this.chkScale.Text = "Scale to Window Size";
            this.chkScale.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(18, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 1);
            this.panel4.TabIndex = 59;
            // 
            // errRes
            // 
            this.errRes.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errRes.ContainerControl = this;
            // 
            // errServer
            // 
            this.errServer.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errServer.ContainerControl = this;
            // 
            // lnkClear
            // 
            this.lnkClear.AutoSize = true;
            this.lnkClear.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkClear.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkClear.Location = new System.Drawing.Point(16, 7);
            this.lnkClear.Name = "lnkClear";
            this.lnkClear.Size = new System.Drawing.Size(31, 13);
            this.lnkClear.TabIndex = 61;
            this.lnkClear.TabStop = true;
            this.lnkClear.Text = "Clear";
            this.lnkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClear_LinkClicked);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.lstRecent);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(7, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(669, 403);
            this.panel5.TabIndex = 62;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 372);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(667, 29);
            this.panel7.TabIndex = 64;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lnkRemove);
            this.panel8.Controls.Add(this.lnkClear);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(557, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(110, 29);
            this.panel8.TabIndex = 63;
            // 
            // lnkRemove
            // 
            this.lnkRemove.AutoSize = true;
            this.lnkRemove.Enabled = false;
            this.lnkRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkRemove.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkRemove.Location = new System.Drawing.Point(53, 7);
            this.lnkRemove.Name = "lnkRemove";
            this.lnkRemove.Size = new System.Drawing.Size(47, 13);
            this.lnkRemove.TabIndex = 62;
            this.lnkRemove.TabStop = true;
            this.lnkRemove.Text = "Remove";
            this.lnkRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRemove_LinkClicked);
            // 
            // lstRecent
            // 
            this.lstRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstRecent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ServerLabel,
            this.Server,
            this.Login,
            this.Resolution});
            this.lstRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstRecent.FullRowSelect = true;
            this.lstRecent.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstRecent.HideSelection = false;
            this.lstRecent.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lstRecent.Location = new System.Drawing.Point(0, 0);
            this.lstRecent.MultiSelect = false;
            this.lstRecent.Name = "lstRecent";
            this.lstRecent.Size = new System.Drawing.Size(667, 401);
            this.lstRecent.TabIndex = 63;
            this.lstRecent.UseCompatibleStateImageBehavior = false;
            this.lstRecent.View = System.Windows.Forms.View.Details;
            this.lstRecent.ItemActivate += new System.EventHandler(this.lstRecent_ItemActivate);
            this.lstRecent.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstRecent_ItemSelectionChanged);
            this.lstRecent.SelectedIndexChanged += new System.EventHandler(this.lstRecent_SelectedIndexChanged);
            // 
            // ServerLabel
            // 
            this.ServerLabel.Text = "Label";
            this.ServerLabel.Width = 200;
            // 
            // Server
            // 
            this.Server.Text = "Server";
            this.Server.Width = 200;
            // 
            // Login
            // 
            this.Login.Text = "Login";
            this.Login.Width = 160;
            // 
            // Resolution
            // 
            this.Resolution.Text = "Resolution";
            this.Resolution.Width = 90;
            // 
            // errConnect
            // 
            this.errConnect.ContainerControl = this;
            // 
            // tmrConnect
            // 
            this.tmrConnect.Enabled = true;
            this.tmrConnect.Interval = 2000;
            this.tmrConnect.Tick += new System.EventHandler(this.tmrConnect_Tick);
            // 
            // errInfo
            // 
            this.errInfo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errInfo.ContainerControl = this;
            this.errInfo.Icon = ((System.Drawing.Icon)(resources.GetObject("errInfo.Icon")));
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 94);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtLabel);
            this.splitContainer1.Panel1.Controls.Add(this.lnkUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.txtServer);
            this.splitContainer1.Panel1.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.chkScale);
            this.splitContainer1.Panel1.Controls.Add(this.txtLogin);
            this.splitContainer1.Panel1.Controls.Add(this.chkAdmin);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.lstRes);
            this.splitContainer1.Panel1.Controls.Add(this.txtPass);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.splitContainer1.Size = new System.Drawing.Size(959, 419);
            this.splitContainer1.SplitterDistance = 273;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(14, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Label:";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(17, 39);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(228, 20);
            this.txtLabel.TabIndex = 0;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(959, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(806, 573);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Feincraft Remote 4.0 Tesseract";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.Shown += new System.EventHandler(this.MainFrame_Shown);
            this.Resize += new System.EventHandler(this.MainFrame_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errServer)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLogged;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox lstRes;
        private System.Windows.Forms.CheckBox chkAdmin;
        private System.Windows.Forms.CheckBox chkScale;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ErrorProvider errRes;
        private System.Windows.Forms.ErrorProvider errServer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.LinkLabel lnkClear;
        private System.Windows.Forms.LinkLabel lnkRemove;
        private System.Windows.Forms.ListView lstRecent;
        private System.Windows.Forms.ColumnHeader Server;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Resolution;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.ErrorProvider errConnect;
        private System.Windows.Forms.Timer tmrConnect;
        private System.Windows.Forms.ErrorProvider errInfo;
        private System.Windows.Forms.LinkLabel lnkUpdate;
        private System.Windows.Forms.PictureBox btnUpdate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.ColumnHeader ServerLabel;
        private System.Windows.Forms.Panel panel3;
    }
}

