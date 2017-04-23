using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationDungeon
{
    class Bandit : Enemy
    {

        private string name;
        public Bandit()
        {

        }
        public Bandit(string name)
        {
            this.Speed = 1; //Default speed of Bandit
            this.Health = 50;
            this.button1.Image = System.Drawing.Image.FromFile(@"Bandit.png");
        }

        public override string CharacterName
        {
            set
            {
                name = value;
                Console.WriteLine($"setting Bandit name to: {name}");
            }
            get
            {
                return name;
            }
        }

        public override int Health
        {
            set
            {
                health = value;
                try
                {
                    healthBar.Value = value;
                }
                catch
                {
                    //Character has died
                    this.Visible = false;
                }
            }
            get
            {
                return health;
            }
        }
        public override int[] Attack()
        {
            //This will be the Attack method for the specific character, overriden based off character
            int[] tempArray = new int[2];
            

            return tempArray;


        }
        public override void Defense(int strength, int intelligence)
        {
            //This is the method that will receive the attacks and adjust the damage according to the character.

            
        }

        //protected override void button1_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("derived");
        //    MessageBox.Show("Bandit Clicked");
        //    Console.WriteLine("Bandit Clicked");

        //}
    }
}
