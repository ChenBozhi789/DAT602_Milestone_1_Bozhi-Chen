﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAT602_MIlestone_One
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdminManagerForm adminManagerForm = new AdminManagerForm();
            adminManagerForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AdminManagerForm adminManagerForm = new AdminManagerForm();
            adminManagerForm.ShowDialog();
        }
    }
}
