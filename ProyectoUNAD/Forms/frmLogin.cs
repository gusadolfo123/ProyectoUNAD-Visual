using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUNAD.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            #region Dibuja circulo azul en pantalla            
            //SolidBrush myBrush = new SolidBrush(Color.White);            
            //Graphics formGraphics;
            //formGraphics = this.CreateGraphics();
            //formGraphics.SmoothingMode = SmoothingMode.AntiAlias;
            //formGraphics.FillEllipse(myBrush, new Rectangle(-400, -200, 800, 800));
            #endregion

            base.OnPaint(e);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Metodo sobreescrito para que se pueda mover la pantalla cuando la propiedad formborderstyle = none
        /// </summary>
        /// <UrlResource>https://stackoverflow.com/questions/1241812/how-to-move-a-windows-form-when-its-formborderstyle-property-is-set-to-none</UrlResource>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
