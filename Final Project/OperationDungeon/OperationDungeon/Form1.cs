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
        
        Character[,] grid = new Character[2, 3];
        //Will hold the order of players to be played, may need to decrease the number of turnsLeft for each
        Character[] playerTurnQueue = new Character[6];

        public Form1()
        {
            InitializeComponent();
            
            
        }

        
        private void LoadCharacters()
        { 
            /*
             * 
             *This needs to be Automated based on user inputs at the beginning
             * -Have user enter information, hero: name, location, type(Although they only get 1 of each)
             *  
             *When Enemies are generated
             *  -Either have them spawn based off of random numbers or have it based on number of levels completed
             *  - 
             * 
             * 
             */

            /****add a switch case statement, return an array from creating a game of characters to be placed, should return in order of placement***/
            //Create Hero 1
            grid[0, 0] = new Warrior("WarriorKommon");
            grid[0, 0].Location = new Point(100, 50);
            this.Controls.Add(grid[0, 0]);

            //Create Hero 2
            //grid[0, 1] = new Character("CharacterKommon");
            //grid[0, 1].Location = new Point(100, 175);
            //this.Controls.Add(grid[0, 1]);

            ////Create Hero 3
            //grid[0, 2] = new Character("CharacterKommon");
            //grid[0, 2].Location = new Point(100, 300);
            //this.Controls.Add(grid[0, 2]);

            //Create Enemy 1
            grid[1, 0] = new Bandit("BanditKommon");
            grid[1, 0].Location = new Point(550, 50);
            this.Controls.Add(grid[1, 0]);

            ////Create Enemy 2
            //grid[1, 1] = new Character("CharacterKommon");
            //grid[1, 1].Location = new Point(550, 175);
            //this.Controls.Add(grid[1, 1]);

            ////Create Enemy 3
            //grid[1, 2] = new Character("CharacterKommon");
            //grid[1, 2].Location = new Point(550, 300);
            //this.Controls.Add(grid[1, 2]);
            /*
             * 
             * 
             * Debugging Purposes, Console Print out of various characters to check override methods/properties
             * 
             * 
             * 
             * 
             */
            Game game = new OperationDungeon.Game(grid);
            Console.WriteLine($"Warrior Speed = : {grid[0,0].Speed} Should be 2");
            Console.WriteLine($"Character Speed = : {grid[0, 1].Speed} Should be 0");



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
            //Game game = new OperationDungeon.Game();
            LoadCharacters();
        }

        private void character_load(object sender, EventArgs e)
        {
           //can omit
        }
    }
}
