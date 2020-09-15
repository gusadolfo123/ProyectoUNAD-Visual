using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUNAD.Forms
{
    public partial class frmConditions : Form
    {
        private static frmConditions _instance;

        public static frmConditions GetInstance()
        {
            if (_instance == null)
                _instance = new frmConditions();
            return _instance;
        }

        public frmConditions()
        {
            InitializeComponent();
        }

        private void frmConditions_Load(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe src=\"{0}\" width=\"100%\" height=\"360\" " +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/7gP_mDMfJwo";
            this.webBrowser1.DocumentText = string.Format(embed, url);
        
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
