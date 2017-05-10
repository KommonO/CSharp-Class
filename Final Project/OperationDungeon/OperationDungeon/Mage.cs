using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationDungeon
{
    class Mage : Hero
    {
        private string name;
        private int turnCount;
        int intelligence;
        int strength;
        private int speed;
        public Mage()
        {

        }
        public Mage(string name)
        {
            this.CharacterName = name;
            this.Speed = 3;
            this.Health = 100;
            this.button1.Image = System.Drawing.Image.FromFile(@"Mage.png");
            this.TurnCount = Speed;
            this.intelligence = 20;
            this.strength = 20;
            this.skillPointsBar.Maximum = 99;
            chooseAttackComboBox.Items.Add("Electrocute");
            chooseAttackComboBox.Items.Add("Burn ");
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
        public override int SkillPoints
        {
            set
            {
                skillPoints = value;
                try
                {
                    skillPointsBar.Value = value;
                }
                catch
                {
                    chooseAttackComboBox.Items.Add("Special");
                }
            }
            get
            {
                return skillPoints;
            }
        }

        public override int[] Attack(int attackType)
        {
            //method to determine attack based on Strength(Physical strength) and Intelligence(Magical Strength)
            //alters the health bar of others
            //value sent to the other's defense, return a value 

            int[] attackArray = new int[2] { strength, intelligence };
            Console.WriteLine($"Mage Attac Method ran, attackArray.Count: {attackArray.Count()}");
            return attackArray;

        }
        public override void Defense(int strength, int intelligence)
        {
            //alters the health bar of self
            this.Health = this.Health - (strength + intelligence);
        }
    }
}

