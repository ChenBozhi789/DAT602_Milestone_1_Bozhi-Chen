using System;
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
    public partial class MainGameLobby : Form
    {
        public MainGameLobby()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GamePlayForm gamePlayForm = new GamePlayForm();
            gamePlayForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GamePlayForm gamePlayForm = new GamePlayForm();
            gamePlayForm.ShowDialog();
        }

        private void btnAdminconsole_Click(object sender, EventArgs e)
        {
            AdminMainForm adminMainForm = new AdminMainForm();
            adminMainForm.ShowDialog();
        }
    }
}
