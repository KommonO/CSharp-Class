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
        private int turnCount;
        int intelligence;
        int strength;
        private int speed;
        bool isDead = false;
        public Warrior()
        {

        }
        public Warrior(string name)
        {
            Console.WriteLine($"Warrior Created, name = {name}");
            this.CharacterName = name;
            this.Speed = 1;
            this.Health = 100;
            this.SkillPoints = 50;
            this.skillPointsBar.Maximum = 99;
            this.button1.Image = System.Drawing.Image.FromFile(@"Warrior.png");
            this.TurnCount = Speed;
            this.intelligence = 0;
            this.strength = 20;
            chooseAttackComboBox.Items.Add("Strike");
            chooseAttackComboBox.SelectedIndex = 0;

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
        //public override int Health
        //{
        //    set
        //    {
        //        health = value;
        //        try
        //        {
        //            healthBar.Value = value;
        //            healthValueLabel.Text = $"{health}/100";
        //        }
        //        catch
        //        {
        //            if (health > 0)
        //            {

        //                healthBar.Value = healthBar.Maximum;
        //                healthValueLabel.Text = $"{health}/100";
        //            }
        //            else
        //            {
        //                //Character has died
        //                this.Visible = false;
        //                isDead = true;

        //            }
                  
                    
        //        }
        //    }
        //    get
        //    {
        //        return health;
        //    }
        //}
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
                    //Skill Points bar is full. Add the special
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
            Console.WriteLine($"Warrior Attac Method ran, attackArray.Count: {attackArray.Count()}");
            //Health = Health - 10;
            return attackArray;

        }
        public override void Defense(int strength, int intelligence)
        {
            //alters the health bar of self
            this.Health = this.Health - (strength + intelligence);
        }
        //protected override void characterSelectSubmit_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("derived");
        //    MessageBox.Show("Warrior Clicked");
        //    Console.WriteLine("Warrior Clicked");

        //    Defense(5,5);
        //}
    }
}
