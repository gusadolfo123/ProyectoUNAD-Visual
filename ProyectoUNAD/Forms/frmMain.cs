using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUNAD.Forms
{
    public partial class frmMain : Form
    {

        private Form _currentChildForm;
        private IconButton currentButton;
        private Panel leftBorderBtn;
        bool drag = false;
        Point start_point = new Point(0, 0);

        private static frmMain _instance;

        public static frmMain GetInstance()
        {
            if (_instance == null)
                _instance = new frmMain();
            return _instance;
        }

        private frmMain() 
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnlMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void OpenFormChild(Form childForm)
        {
            if(_currentChildForm != null)
            {
                // open only form
                _currentChildForm.Close();
            }

            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlPrimary.Controls.Add(childForm);
            pnlPrimary.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();

                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(0, 68, 107);
                currentButton.ForeColor = color;                
                currentButton.IconColor = color;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                lblTitle.Text = currentButton.Text;
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {                
                currentButton.BackColor = Color.FromArgb(0, 74, 107);
                currentButton.ForeColor = Color.White;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnBasicOp_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
            OpenFormChild(new frmBasicOperations());
        }

        private void btnConditional_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void btnIterable_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.White);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        //{
        //    drag = true;
        //    start_point = new Point(e.X, e.Y);
        //}

        //private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (drag)
        //    {
        //        Point p = PointToScreen(e.Location);
        //        this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
        //    }
        //}

        //private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        //{
        //    drag = false;
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
            lblTitle.Text = "Inicio";
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }
    }
}
