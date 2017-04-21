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
        
        public Character()
        {
            InitializeComponent();
        }
        public Character(string name)
        {
            InitializeComponent();
            this.CharacterName = name;
        }
        
        public string CharacterName
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

        protected virtual void button1_Click(object sender, EventArgs e)
        {
            //Character s = (Character)sender;
            Console.WriteLine($"Character Clicked: {name} and {name}");
            //Console.WriteLine($"Character sender Clicked: {s.Name} and {s.name}");


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
