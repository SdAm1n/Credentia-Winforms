﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Credentia_Winforms
{
    public partial class AllLoginsForm : Form
    {
        public AllLoginsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AllLoginsForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
