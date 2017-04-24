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
        private int turnCount;
        public int speed;
        bool isDead = false;
        public Bandit()
        {

        }
        public Bandit(string name)
        {
            this.Speed = 1; //Default speed of Bandit
            this.CharacterName = name;
            this.Health = 100;
            this.button1.Image = System.Drawing.Image.FromFile(@"Bandit.png");
            this.TurnCount = Speed;
            Console.WriteLine($"initial speed for {name} = {Speed}");
            Console.WriteLine($"initial turnCount for {name} = {TurnCount}");

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
                    isDead = true;
                }
            }
            get
            {
                return health;
            }
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
        public override int[] Attack()
        {
            //This will be the Attack method for the specific character, overriden based off character
            int[] tempArray = new int[2] { 51,50};
            

            return tempArray;


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
        public override void Defense(int strength, int intelligence)
        {
            //This is the method that will receive the attacks and adjust the damage according to the character.
            this.Health = this.Health - (strength + intelligence);

        }

        //protected override void button1_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("derived");
        //    MessageBox.Show("Bandit Clicked");
        //    Console.WriteLine("Bandit Clicked");

        //}
    }
}
