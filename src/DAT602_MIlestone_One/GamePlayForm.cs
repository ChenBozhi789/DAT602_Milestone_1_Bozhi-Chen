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
    public partial class GamePlayForm : Form
    {
        public GamePlayForm()
        {
            InitializeComponent();
            CreateGrid(10, 10, 10, 30, gbTester);
        }

        private void CreateGrid(int rows, int cols, int xOffset, int yOffset, System.Windows.Forms.GroupBox groupbox)
        {
            Random random = new Random();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    // Set coordinates of the button
                    btn.Location = new Point(xOffset + col * 30, yOffset + row * 30);
                    btn.Name = $"btn_{row}_{col}";
                    int randomNumber = random.Next(1, 100);
                    // "HomeTile" is the starting point of the game
                    if (row == 0 && col == 0)
                    {
                        btn.BackColor = Color.Green;
                    }

                    if (randomNumber % 2 == 0)
                    {
                        btn.Click += new EventHandler(EmptyButton_Click);

                    }
                    else if (randomNumber % 3 == 0)
                    {
                        btn.Click += new EventHandler(BombButton_Click);
                    }
                    else
                    {
                        btn.Click += new EventHandler(JewelButton_Click);
                    }
                    groupbox.Controls.Add(btn);
                }
            }

            Size size = gbTester.Size;
            int width = size.Width; // Length of X
            int height = size.Height; // Length of Y
            //MessageBox.Show("The auto size of GroupBox：Width = " + width + ", Height = " + height +
            //    ", X Coordinate = " + gbTester.Location.X + ", Y Coordinate = " + gbTester.Location.Y);

            lblTurn.Location = new Point(width + 50, 14);
            lblTime.Location = new Point(width + 150, 14);
            gbPlayera.Location = new Point(width + 50, 40);
            gbPlayerb.Location = new Point(width + 50, 220);
        }

        private void EmptyButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clickedButton.BackColor = Color.Gray;
        }

        private void JewelButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clickedButton.BackColor = Color.Red;
        }

        private void BombButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            clickedButton.BackColor = Color.Black;
        }
    }
}
