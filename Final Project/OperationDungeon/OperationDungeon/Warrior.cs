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
            this.WarriorName = name;
             

        }
        public string WarriorName
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
        protected override void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("derived");
            MessageBox.Show("Warrior Clicked");
            Console.WriteLine("Warrior Clicked");

        }
    }
}
