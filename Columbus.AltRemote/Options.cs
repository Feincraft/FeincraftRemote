using Columbus.AltRemote.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Columbus.AltRemote
{
    public partial class Options : Form
    {
        /* Constructors */
        #region Constructors
        /// <summary>
        /// Default constructor
        /// </summary>
        public Options()
        {
            InitializeComponent();
            
        }
        #endregion 

        /* Event handlers */
        #region Event handlers
        private void Options_Load(object sender, EventArgs e)
        {
            chkPassword.Checked = Settings.Default.RememberPasswords;
            chkConnection.Checked = Settings.Default.RememberRecent;
            chkGpu.Checked = Settings.Default.UseGPU;
            chkUpdates.Checked = Settings.Default.CheckUpdates;
            chkPassword.Enabled = chkConnection.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.RememberPasswords = chkPassword.Checked;
            Settings.Default.RememberRecent = chkConnection.Checked;
            Settings.Default.UseGPU = chkGpu.Checked;
            Settings.Default.CheckUpdates = chkUpdates.Checked;
            Settings.Default.Save();
            this.Close();
        }

        private void chkConnection_CheckedChanged(object sender, EventArgs e)
        {
            chkPassword.Enabled = chkConnection.Checked;
            chkPassword.Checked = chkConnection.Checked;
        }
        #endregion
    }
}
