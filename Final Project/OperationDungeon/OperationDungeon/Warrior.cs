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
            this.Speed = 2; //Default speed of a Warrior character is 2? Confirm with the UML Diagram
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
        protected override void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("derived");
            MessageBox.Show("Warrior Clicked");
            Console.WriteLine("Warrior Clicked");

        }
    }
}
