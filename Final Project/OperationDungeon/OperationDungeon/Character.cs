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
        private int turnCount;
        bool flag = false;
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
        public int Speed
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
        public virtual int Health
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

        //protected virtual void button1_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
