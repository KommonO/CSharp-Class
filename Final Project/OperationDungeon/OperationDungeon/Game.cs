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
        List<Character> characterList = new List<Character>();
        bool startup = false;

        public Game()
        {
            //MessageBox.Show("Game Created");   
            //Here we shall prompt the player for the Game Start Settings, Player placement, name, custom settings. 
        }
        public Game(Character[,] charArray)
        {
            Console.WriteLine("Game Created(Constructor2). Array passed:");
            Console.WriteLine($"charArray[0,0]: {charArray[0, 0]}");
            Console.WriteLine($"charArray[0,1]: {charArray[0, 1]}");
            Console.WriteLine($"charArray[0,2]: {charArray[0, 2]}");
            Console.WriteLine($"charArray[0,0]: {charArray[1, 0]}");
            Console.WriteLine($"charArray[0,1]: {charArray[1, 1]}");
            Console.WriteLine($"charArray[0,2]: {charArray[1, 2]}");
            characterList?.Add(charArray[0,0]);
            characterList?.Add(charArray[0, 1]);
            characterList?.Add(charArray[0, 2]);
            characterList?.Add(charArray[1, 0]);
            characterList?.Add(charArray[1, 1]);
            characterList?.Add(charArray[1, 2]);

            //Line required to erase the empty items in the characterList
            characterList = characterList.Where(s => !string.IsNullOrWhiteSpace(Convert.ToString(s))).Distinct().ToList();
            Console.WriteLine("Finish. characterList.Count: " + characterList.Count());
            
            //startup = true;
        }
        private List<Character> TurnSort(List<Character> list)
        {
            //sorts the list to be in order of whos turn it is.
            List<int> tempList = new List<int>();
            for(int i = 0; i < list.Count(); i++)
            {
                tempList.Add(list[i].Speed);
            }


            return list;
        }
        public void StartGame()
        {
            //TurnSort(characterList);
            //play game
            int temp = 100;
            bool tempBool = false;
            Character tempCharacter;
            //MessageBox.Show("Testing");



            while (true)
            {
                //Decide who's turn it is

                for (int s = 0; s < characterList.Count(); s++)
                {
                    Console.WriteLine("for loop entered");
                    //search the list for the lowest turnCount
                    if (characterList[s].TurnCount < temp)
                    {
                        Console.WriteLine("for loop if entered");
                        temp = characterList[s].TurnCount;
                        tempCharacter = characterList[s];
                    }
                }


                //wait until user clicks to attack
                Console.WriteLine("Before !tempBool Loop");
                //while (!tempBool)
                //{
                //    //wait until an item is clicked
                //    for (int a = 0; a < characterList.Count(); a++)
                //    {
                //        tempBool = characterList[a].Flag;
                //    }
                //}
                Console.WriteLine("After !tempBool Loop");

                //possible a while which waited until the flag is set from a button being clicked. 

            }
        }

        static void swap(int index1, int index2, ref List<Character> charList)
        {
            //Console.WriteLine($"arr size = {arr.Count()}");
            Character temp = charList[index1];
            charList[index1] = charList[index2];
            charList[index2] = temp;
        }

    }
}
