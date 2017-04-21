using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationDungeon
{
    public partial class Form1 : Form
    {
        //Character Hero1 = new Character();
        //Character Hero2 = new Character();
        //Character Hero3 = new Character();
        //Character Enemy1 = new Character();
        //Character Enemy2 = new Character();
        //Character Enemy3 = new Character();
        Character[,] grid = new Character[2, 3];


        public Form1()
        {
            InitializeComponent();
            
            
        }

        
        private void LoadCharacters()
        { 
            //for (int i = 0; i < grid.GetLength(0); i++)
            //{
            //    for (int j = 0; j < grid.GetLength(1); j++)
            //    {

            //        //grid[i, j] = new Character();
            //        ////add 30 so that it will not interfere with the menustrip
            //        //grid[i, j].Location = new Point(i * 50, j * 50 + 30); //* 50 because of size of the cells
            //        //grid[i, j].Position = new Point(i, j);
            //        //grid[i, j].CellClick += new EventHandler(ClearAdjacent);
            //        //this.Controls.Add(grid[i, j]);
            //        grid[i,j] = 

            //    }
            //}
            grid[0, 0] = new Warrior("WarriorKommon");
            grid[0, 0].Location = new Point(100, 50);
            this.Controls.Add(grid[0, 0]);

            grid[0, 1] = new Character("WarriorKommon");
            grid[0, 1].Location = new Point(100, 175);
            this.Controls.Add(grid[0, 1]);

            grid[0, 2] = new Character("WarriorKommon");
            grid[0, 2].Location = new Point(100, 300);
            this.Controls.Add(grid[0, 2]);

            grid[1, 0] = new Bandit("BanditKommon");
            grid[1, 0].Location = new Point(550, 50);
            this.Controls.Add(grid[1, 0]);

            grid[1, 1] = new Character("WarriorKommon");
            grid[1, 1].Location = new Point(550, 175);
            this.Controls.Add(grid[1, 1]);

            grid[1, 2] = new Character("WarriorKommon");
            grid[1, 2].Location = new Point(550, 300);
            this.Controls.Add(grid[1, 2]);



        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the Form/Game if the Exit button is clicked
            this.Close();
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stats stats = new OperationDungeon.Stats();
            stats.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCharacters();
        }

        private void character_load(object sender, EventArgs e)
        {
            this.Text = this.Name; 
        }
    }
}
