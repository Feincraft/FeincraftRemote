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
    public partial class VncClient : Form
    {
        public VncClient()
        {
            InitializeComponent();
        }

        private void VncClient_Load(object sender, EventArgs e)
        {
            vncPrime.Connect("fainberg.dontexist.com", false, true);    
        }
    }
}
