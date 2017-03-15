using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    class Game
    {
        //Game properties


        public Game()
        {
            MessageBox.Show("New Game Created");
            Gameboard gameboard = new Gameboard();
        }
    }
}
