using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MineSweeperForm : Form
    {
        List<Button> buttons = new List<Button>();
        int nameIncrement = 0;
        public MineSweeperForm()
        {
            InitializeComponent();
        }

        private void statsMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("stats clicked");
        }
        private void restartMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("restart clicked");
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("exit clicked");
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("help clicked");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //When the form is loaded, create a new game, which will create a new board or round.
            Game game = new Game();
            Gameboard gameboard = new Gameboard();
            //MessageBox.Show($"should be text : {Convert.ToString(gameboard.GetStatus(0,0))}");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //g.DrawLine(System.Drawing.Pens.Red, tableLayoutPanel1.Left, tableLayoutPanel1.Top, tableLayoutPanel1.Right, tableLayoutPanel1.Bottom);

            //MessageBox.Show($"{this.Controls.Count}");

            //recursive for loop, concatenate the two, I and J, and set that button to dissappear in the list. 
            
            //int newNumber = int.Parse(i.ToString() + base.ToString());
            Button newButton = new Button();
            //newButton.Click += new EventHandler(this.TileBtn_Click);
            //newButton.Name = 
            buttons.Add(newButton);
            tableLayoutPanel1.Controls.Add(newButton);

            
            
            //MessageBox.Show($"new button added");
            
            //newButton.Click += new EventHandler(this.TileBtn_Click);
            
        }
        void TileBtn_Click(Object sender, EventArgs e)
        {
            //MessageBox.Show("Tilebtn_Clc");
            Point point = (Point)sender;
            label1.Text = $"{point}";

            //Button clickedButton = (Button)sender;

            //clickedButton.Visible = false;
        }

       
    }
}
