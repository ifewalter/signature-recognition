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
    public partial class HelpViewer : Form
    {
        public HelpViewer()
        {
            InitializeComponent();
        }

        private void HelpViewer_Load(object sender, EventArgs e)
        {

            string helpFileLocation;
            string thisLocation;
            thisLocation = Application.StartupPath.ToString();
            helpFileLocation = thisLocation + "/Help/help.html";
            webBrowser1.Url = new Uri(helpFileLocation);
        }
    }
}
