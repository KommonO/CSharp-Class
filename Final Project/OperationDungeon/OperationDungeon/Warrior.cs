using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationDungeon
{
    class Warrior : Hero
    {
        private string name;
        public Warrior()
        {

        }
        public Warrior(string name)
        {
            Console.WriteLine($"Warrior Created, name = {name}");
            this.CharacterName = name;
            this.Speed = 1; //Default speed of a Warrior character is 2? Using 1 for first submission purposes in case I can't add multiple Confirm with the UML Diagram
            //this.healthBar.Style = ProgressBarStyle.Blocks;
            this.Health = 25;
            this.button1.Image = System.Drawing.Image.FromFile(@"Warrior.png");
            
            //Somehow print the sprite of the character on the button 
            //this.healthBar.Value = 100;
        }
        public override string CharacterName
        {
            set
            {
                name = value;
                Console.WriteLine($"setting hero name to: {name}");
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
                healthBar.Value = value;
                
            }
            get
            {
                return health;
            }
        }

        private int[] Attack()
        {
            //method to determine attack based on Strength(Physical strength) and Intelligence(Magical Strength)
            //alters the health bar of others
            //value sent to the other's defense, return a value 
            int[] attackArray = new int[2] { 0, 0 };
            Console.WriteLine($"Warrior Attac Method ran, attackArray.Count: {attackArray.Count()}");
            //Health = Health - 10;
            return attackArray;

        }
        private void Defense(int strength, int intelligence)
        {
            //alters the health bar of self
        }
        protected override void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("derived");
            MessageBox.Show("Warrior Clicked");
            Console.WriteLine("Warrior Clicked");

            Attack();
        }
    }
}
