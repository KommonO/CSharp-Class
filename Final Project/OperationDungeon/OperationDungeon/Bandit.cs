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


        public Bandit()
        {

        }
        public Bandit(string name)
        {

        }
        protected override void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("derived");
            MessageBox.Show("Bandit Clicked");
            Console.WriteLine("Bandit Clicked");

        }
    }
}
