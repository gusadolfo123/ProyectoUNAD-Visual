namespace ProyectoUNAD.Forms
{
    partial class frmMain
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnIterable = new FontAwesome.Sharp.IconButton();
            this.btnConditional = new FontAwesome.Sharp.IconButton();
            this.btnBasicOp = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlPrimary = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlProgress.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(107)))));
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnIterable);
            this.pnlMenu.Controls.Add(this.btnConditional);
            this.pnlMenu.Controls.Add(this.btnBasicOp);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.ForeColor = System.Drawing.Color.White;
            this.pnlMenu.Location = new System.Drawing.Point(0, 27);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 502);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(107)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconSize = 34;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(200, 60);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = " Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnIterable
            // 
            this.btnIterable.BackColor = System.Drawing.Color.Transparent;
            this.btnIterable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIterable.FlatAppearance.BorderSize = 0;
            this.btnIterable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.btnIterable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.btnIterable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIterable.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnIterable.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIterable.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.btnIterable.IconColor = System.Drawing.Color.White;
            this.btnIterable.IconSize = 34;
            this.btnIterable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIterable.Location = new System.Drawing.Point(0, 302);
            this.btnIterable.Name = "btnIterable";
            this.btnIterable.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnIterable.Rotation = 0D;
            this.btnIterable.Size = new System.Drawing.Size(200, 60);
            this.btnIterable.TabIndex = 3;
            this.btnIterable.Text = " Ciclos";
            this.btnIterable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIterable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIterable.UseVisualStyleBackColor = false;
            this.btnIterable.Click += new System.EventHandler(this.btnIterable_Click);
            // 
            // btnConditional
            // 
            this.btnConditional.BackColor = System.Drawing.Color.Transparent;
            this.btnConditional.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConditional.FlatAppearance.BorderSize = 0;
            this.btnConditional.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.btnConditional.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.btnConditional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConditional.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConditional.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConditional.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnConditional.IconColor = System.Drawing.Color.White;
            this.btnConditional.IconSize = 34;
            this.btnConditional.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConditional.Location = new System.Drawing.Point(0, 242);
            this.btnConditional.Name = "btnConditional";
            this.btnConditional.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnConditional.Rotation = 0D;
            this.btnConditional.Size = new System.Drawing.Size(200, 60);
            this.btnConditional.TabIndex = 2;
            this.btnConditional.Text = " Condicionales";
            this.btnConditional.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConditional.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConditional.UseVisualStyleBackColor = false;
            this.btnConditional.Click += new System.EventHandler(this.btnConditional_Click);
            // 
            // btnBasicOp
            // 
            this.btnBasicOp.BackColor = System.Drawing.Color.Transparent;
            this.btnBasicOp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBasicOp.FlatAppearance.BorderSize = 0;
            this.btnBasicOp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.btnBasicOp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(80)))), ((int)(((byte)(107)))));
            this.btnBasicOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasicOp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBasicOp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBasicOp.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnBasicOp.IconColor = System.Drawing.Color.White;
            this.btnBasicOp.IconSize = 34;
            this.btnBasicOp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasicOp.Location = new System.Drawing.Point(0, 182);
            this.btnBasicOp.Name = "btnBasicOp";
            this.btnBasicOp.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnBasicOp.Rotation = 0D;
            this.btnBasicOp.Size = new System.Drawing.Size(200, 60);
            this.btnBasicOp.TabIndex = 1;
            this.btnBasicOp.Text = " Operaciones básicas";
            this.btnBasicOp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasicOp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBasicOp.UseVisualStyleBackColor = false;
            this.btnBasicOp.Click += new System.EventHandler(this.btnBasicOp_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblNameUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 182);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ProyectoUNAD.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.Location = new System.Drawing.Point(38, 155);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(114, 16);
            this.lblNameUser.TabIndex = 0;
            this.lblNameUser.Text = "Gustavo Moreno";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(107)))));
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(842, 27);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // pnlProgress
            // 
            this.pnlProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(54)))), ((int)(((byte)(115)))));
            this.pnlProgress.Controls.Add(this.progressBar1);
            this.pnlProgress.Controls.Add(this.label1);
            this.pnlProgress.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProgress.ForeColor = System.Drawing.Color.White;
            this.pnlProgress.Location = new System.Drawing.Point(200, 27);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(642, 38);
            this.pnlProgress.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(104, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(501, 13);
            this.progressBar1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tu Progreso";
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(642, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inicio";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 40);
            this.panel1.TabIndex = 3;
            // 
            // pnlPrimary
            // 
            this.pnlPrimary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrimary.Location = new System.Drawing.Point(200, 105);
            this.pnlPrimary.Name = "pnlPrimary";
            this.pnlPrimary.Size = new System.Drawing.Size(642, 424);
            this.pnlPrimary.TabIndex = 4;
            this.pnlPrimary.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPrimary_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 529);
            this.Controls.Add(this.pnlPrimary);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlProgress.ResumeLayout(false);
            this.pnlProgress.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton btnBasicOp;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnIterable;
        private FontAwesome.Sharp.IconButton btnConditional;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlPrimary;
    }
}