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



        public Form1()
        {
            InitializeComponent();
        }

        private void LoadCharacters()
        {
            //Hero1 = new OperationDungeon.Character();
            //Hero1.Location = new Point (200, 200);
            //this.Controls.Add(Hero1);
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
    }
}
