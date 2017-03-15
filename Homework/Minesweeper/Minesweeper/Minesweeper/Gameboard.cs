using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    class Gameboard
    {
        //Gameboard Properties
        int[,] tileArray = new int[10,10];
        private Random rnd = new Random();

        public Gameboard()
        {
            //MessageBox.Show("new gameboard created");
            //initialize all spots to 0 (Success)0-9
            ClearBoard();
            //MessageBox.Show($"{tileArray[9,9]}");
            PlaceMines(20);
            //MessageBox.Show($"Tile 1: {tileArray[0,0]}");

        }
        public void ClearBoard()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tileArray[i, j] = 0;
                }
            }
            //MessageBox.Show($"{tileArray[9, 9]}");
        }
        public void PlaceMines(int numMines)
        {
            //This method will randomly place mines(Maybe change name to PlaceMines)
            //MessageBox.Show("PlaceMines() Called Successfully");

            //Pick random coordinates
            for (int i = 0; i < numMines; i++)
            {
                bool tempBool = true;
                while (tempBool)
                {
                    int randX = rnd.Next(0, 10);
                    int randY = rnd.Next(0, 10);
                    if(tileArray[randX,randY] == 1)
                    {

                    }
                    else
                    {
                        SetTile(randX,randY,1);
                        tempBool = false;
                    }
                }
            }


        }
        public int GetStatus(int x, int y)
        {
            return tileArray[x, y];
        }
        public void SetTile(int x, int y,int status)
        {
            tileArray[x, y] = status;
        }
    }
}
