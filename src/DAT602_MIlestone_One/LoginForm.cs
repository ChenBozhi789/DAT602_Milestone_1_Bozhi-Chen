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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            MainGameLobby mainGameLobby = new MainGameLobby();
            mainGameLobby.ShowDialog();
        }
    }
}
