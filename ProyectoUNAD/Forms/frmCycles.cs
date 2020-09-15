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
    public partial class frmCycles : Form
    {
        private static frmCycles _instance;

        public static frmCycles GetInstance()
        {
            if (_instance == null)
                _instance = new frmCycles();
            return _instance;
        }

        public frmCycles()
        {
            InitializeComponent();
        }

        private void frmCycles_Load(object sender, EventArgs e)
        {
            var embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe src=\"{0}\" width=\"100%\" height=\"360\" " +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";
            var url = "https://www.youtube.com/embed/migkiIl5u9k";
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }
    }
}
