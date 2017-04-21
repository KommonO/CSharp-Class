using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperationDungeon
{
    class Game : Form1
    {

        Character[,] grid = new Character[2, 3];
        Character[] playerTurnQueue = new Character[6];


        public Game()
        {
            
        }

    }
}
