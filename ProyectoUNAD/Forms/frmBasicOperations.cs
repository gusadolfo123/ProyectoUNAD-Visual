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
    public partial class frmBasicOperations : Form
    {
        private static frmBasicOperations _instance;

        public static frmBasicOperations GetInstance()
        {
            if (_instance == null)
                _instance = new frmBasicOperations();
            return _instance;
        }

        public frmBasicOperations()
        {
            InitializeComponent();
        }

        private void frmBasicOperations_Load(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe src=\"{0}\" width=\"100%\" height=\"360\" " +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/Ih4JHzhDFbE";
            this.webBrowser1.DocumentText = string.Format(embed, url);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            frmTest childForm = new frmTest();
            frmBasicOperations _currentChildForm = this;
            Panel myPanel = (Panel)this.Parent;

            if (_currentChildForm != null)
            {
                _currentChildForm.Close(); 
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            myPanel.Controls.Add(childForm);
            myPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Width = myPanel.Width;
            childForm.Show();
        }
    }
}
