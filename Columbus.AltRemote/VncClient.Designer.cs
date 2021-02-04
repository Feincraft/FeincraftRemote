namespace Columbus.AltRemote
{
    partial class VncClient
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
            this.vncPrime = new VncSharp.RemoteDesktop();
            this.SuspendLayout();
            // 
            // vncPrime
            // 
            this.vncPrime.AutoScroll = true;
            this.vncPrime.AutoScrollMinSize = new System.Drawing.Size(608, 427);
            this.vncPrime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vncPrime.Location = new System.Drawing.Point(0, 0);
            this.vncPrime.Name = "vncPrime";
            this.vncPrime.Size = new System.Drawing.Size(847, 640);
            this.vncPrime.TabIndex = 0;
            // 
            // VncClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 640);
            this.Controls.Add(this.vncPrime);
            this.Name = "VncClient";
            this.Text = "VncClient";
            this.Load += new System.EventHandler(this.VncClient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VncSharp.RemoteDesktop vncPrime;
    }
}