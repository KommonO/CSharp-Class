using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationDungeon
{
    class Cleric : Hero
    {
        private string name;
        private int turnCount;
        int intelligence;
        int strength;
        private int speed;
        bool isDead = false;
        public Cleric()
        {

        }
        public Cleric(string name)
        {
            Console.WriteLine($"Cleric Created, name = {name}");
            this.CharacterName = name;
            this.Speed = 2; //Default speed of a Warrior character is 2? Using 1 for first submission purposes in case I can't add multiple Confirm with the UML Diagram
            //this.healthBar.Style = ProgressBarStyle.Blocks;
            this.Health = 100;
            this.button1.Image = System.Drawing.Image.FromFile(@"Cleric.png");
            this.TurnCount = Speed;
            this.intelligence = 5;
            this.strength = 15;
            Console.WriteLine($"initial speed for {name} = {Speed}");
            Console.WriteLine($"initial turnCount for {name} = {TurnCount}");
            //Somehow print the sprite of the character on the button 
            //this.healthBar.Value = 100;
        }
        public override bool IsDead
        {
            set
            {
                isDead = value;
                Console.WriteLine($"setting isDead for {name}to: {isDead}");
            }
            get
            {
                return isDead;
            }
        }
        public override int TurnCount
        {
            set
            {
                turnCount = value;
                Console.WriteLine($"setting turnCount for {name}to: {turnCount}");
            }
            get
            {
                return turnCount;
            }
        }
        public override int Speed
        {
            set
            {
                speed = value;
                Console.WriteLine($"Setting speed to: {speed}");

            }
            get
            {
                return speed;
            }
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
                try
                {
                    healthBar.Value = value;
                    healthValueLabel.Text = $"{health}/100";
                }
                catch
                {
                    //Character has died
                    this.Visible = false;
                    isDead = true;
                }
            }
            get
            {
                return health;
            }
        }

        public override int[] Attack()
        {
            //method to determine attack based on Strength(Physical strength) and Intelligence(Magical Strength)
            //alters the health bar of others
            //value sent to the other's defense, return a value 

            int[] attackArray = new int[2] { strength, intelligence };
            Console.WriteLine($"Cleric Attac Method ran, attackArray.Count: {attackArray.Count()}");
            //Health = Health - 10;
            return attackArray;

        }
        public override void Defense(int strength, int intelligence)
        {
            //alters the health bar of self
            this.Health = this.Health - (strength + intelligence);
        }
        //protected override void button1_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("derived");
        //    MessageBox.Show("Warrior Clicked");
        //    Console.WriteLine("Warrior Clicked");

        //    Defense(5,5);
        //}
    }
}

