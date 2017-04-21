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
        public Bandit()
        {

        }
        public Bandit(string name)
        {
            this.Speed = 2; //Default speed of Bandit
            this.Health = 50;
            this.button1.Image = System.Drawing.Image.FromFile(@"Bandit.png");
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
            MessageBox.Show("Bandit Clicked");
            Console.WriteLine("Bandit Clicked");

        }
    }
}
