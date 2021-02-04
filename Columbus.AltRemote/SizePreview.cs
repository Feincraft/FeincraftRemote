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
    public partial class SizePreview : Form
    {
        public SizePreview()
        {
            InitializeComponent();
        }
        public SizePreview(Form caller, Boolean vertical)
        {
            InitializeComponent();
            parent = caller;
            if (vertical) { this.Width = 6; }
            else { this.Height = 6; }
        }
        private Form parent;
        private void SizePreview_Load(object sender, EventArgs e)
        {

        }

        private void SizePreview_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void SizePreview_MouseDown(object sender, MouseEventArgs e)
        {
            parent.Focus();

        }
    }
}
