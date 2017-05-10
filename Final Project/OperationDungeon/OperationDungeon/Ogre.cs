using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationDungeon
{
    class Ogre : Enemy
    {
        private string name;
        private int turnCount;
        int intelligence;
        int strength;
        private int speed;
        bool isDead = false;
        public Ogre()
        {

        }
        public Ogre(string name)
        {
            Console.WriteLine($"Ogre Created, name = {name}");
            this.CharacterName = name;
            this.Speed = 2; 
            this.Health = 100;
            this.button1.Image = System.Drawing.Image.FromFile(@"Ogre.png");
            this.TurnCount = Speed;
            this.intelligence = 0;
            this.strength = 22;
            this.skillPointsBar.Maximum = 99;
            chooseAttackComboBox.Items.Add("Punch");
            chooseAttackComboBox.Items.Add("Throw");
            chooseAttackComboBox.SelectedIndex = 0;

        }
        public override int TurnCount
        {
            set
            {
                turnCount = value;
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
            }
            get
            {
                return name;
            }
        }

        public override int[] Attack(int attackType)
        {
            //method to determine attack based on Strength(Physical strength) and Intelligence(Magical Strength)
            //alters the health bar of others
            //value sent to the other's defense, return a value 

            int[] attackArray = new int[2] { strength, intelligence };
            Console.WriteLine($"Ogre Attac Method ran, attackArray.Count: {attackArray.Count()}");
            return attackArray;

        }
        public override void Defense(int strength, int intelligence)
        {
            //alters the health bar of self
            this.Health = this.Health - (strength + intelligence);
        }
    }
}

