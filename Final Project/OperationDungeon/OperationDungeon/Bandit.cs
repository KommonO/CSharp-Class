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
        int intelligence;
        int strength;
        public Bandit()
        {

        }
        public Bandit(string name)
        {
            this.Speed = 1; //Default speed of Bandit
            this.CharacterName = name;
            this.Health = 100;
            this.SkillPoints = 50;
            this.button1.Image = System.Drawing.Image.FromFile(@"Bandit.png");
            this.TurnCount = Speed;
            this.intelligence = 0;
            this.strength = 15;
            this.skillPointsBar.Maximum = 99;
            chooseAttackComboBox.Items.Add("Slash");
            chooseAttackComboBox.Items.Add("Jab");
            chooseAttackComboBox.SelectedIndex = 0;

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
                    //Character has died
                    //this.Visible = false;
                    //MessageBox.Show("Skill points full");
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
            //This will be the Attack method for the specific character, overriden based off character
            int[] tempArray = new int[2] { strength,intelligence};
            

            return tempArray;


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
        public override void Defense(int strength, int intelligence)
        {
            //This is the method that will receive the attacks and adjust the damage according to the character.
            this.Health = this.Health - (strength + intelligence);

        }
    }
}
