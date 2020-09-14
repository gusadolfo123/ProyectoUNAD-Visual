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

        }
    }
}
