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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void statsMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("stats clicked");
        }
        private void restartMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("restart clicked");
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("exit clicked");
        }

        private void helpMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("help clicked");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gameboard game = new Gameboard();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
