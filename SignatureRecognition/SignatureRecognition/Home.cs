#region Copyright (c), Some Rights Reserved
/*##########################################################################
 * 
 * IBackPropagation.cs
 * -------------------------------------------------------------------------
 * By
 * Ronke Ajibade, Ifeoluwa Okpah, Murat FIRAT, - April 2011
 * 
 * -------------------------------------------------------------------------
 ###########################################################################*/
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SignatureRecognition
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();
        }

        private void trainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Train train = new Train();
            train.MdiParent = this;
            train.Show();
        }

        private void signatureVerificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verify verify = new Verify();
            verify.MdiParent = this;
            verify.Show();
        }

        private void applicationSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Not implemented");
            AppSettings appsettings = new AppSettings();
            appsettings.MdiParent = this;
            appsettings.Show();
        }

        private void signatureRecognitionHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpViewer helpViewer = new HelpViewer();
            helpViewer.MdiParent = this;
            helpViewer.Show();
        }

        private void exitThread(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
