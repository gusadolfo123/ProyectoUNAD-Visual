﻿using System;
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

        }
    }
}
