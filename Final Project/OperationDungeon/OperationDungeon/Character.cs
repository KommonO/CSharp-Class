using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationDungeon
{
    public partial class Character : UserControl
    {
        private string name;
        public int speed;
        public int health;
        //adding skill points to mimic health
        public int skillPoints;
        private int turnCount;
        bool flag = false;
        bool isDead = false;
        public event EventHandler CharacterClick;

        public Character()
        {
            InitializeComponent();
        }
        public Character(string name)
        {
            InitializeComponent();
            this.CharacterName = name;
            this.Speed = 0;
            this.healthBar.Maximum = 100;
            this.Health = 100;
            this.SkillPoints = 50;
            this.skillPointsBar.Maximum = 99;
            
        }
        
        public virtual string CharacterName
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
        public virtual int TurnCount
        {
            set
            {
                turnCount = value;
                Console.WriteLine($"setting turnCount to: {turnCount}");
            }
            get
            {
                return turnCount;
            }
        }
        public bool Flag
        {
            set
            {
                flag = value;
                Console.WriteLine($"setting flag to: {flag}");
            }
            get
            {
                return flag;
            }
        }
        public virtual int Speed
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
        public bool IsDead
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
        //public virtual int Health
        //{
        //    set
        //    {
        //        health = value;
        //        healthBar.Value = value;
        //    }
        //    get
        //    {
        //        return health;
        //    }
        //}
        public int Health
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
                    if (health > 0)
                    {

                        healthBar.Value = healthBar.Maximum;
                        healthValueLabel.Text = $"{health}/100";
                    }
                    else
                    {
                        //Character has died
                        this.Visible = false;
                        isDead = true;

                    }


                }
            }
            get
            {
                return health;
            }
        }
        public virtual int SkillPoints
        {
            set
            {
                skillPoints = value;
                skillPointsBar.Value = value;
            }
            get
            {
                return skillPoints;
            }
        }

        //protected virtual void characterSelectSubmit_Click(object sender, EventArgs e)
        protected void button1_Click(object sender, EventArgs e)
        {
            //Character s = (Character)sender;
            Console.WriteLine("Button clicked");
            //button1.Visible = false;

            if (this.CharacterClick != null)
            {
                this.CharacterClick(this, e);
            }
            //Console.WriteLine($"Character sender Clicked: {s.Name} and {s.name}");


        }
        public virtual int[] Attack(int attackType)
        {
            int[] attackArray = new int[2];
            return attackArray;
        }
        public virtual void Defense(int strength, int intelligence)
        {
            this.Health = this.Health - (strength + intelligence);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
