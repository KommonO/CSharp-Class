using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace OperationDungeon
{
    public partial class Form1 : Form
    {
        
        Character[,] grid = new Character[2, 3];
        //Will hold the order of players to be played, may need to decrease the number of turnsLeft for each
        Character[] playerTurnQueue = new Character[6];
        List<Character> characterList = new List<Character>();
        Character nextCharacter;
        bool flag = false;
        int numEnemies = 0;
        int numHeroes = 0;
        Game game;

        public Form1()
        {
            InitializeComponent();
            

        }

        
        private void LoadCharacters()
        {
            /*
             * 
             *This needs to be Automated based on user inputs at the beginning
             * -Have user enter information, hero: name, location, type(Although they only get 1 of each)
             *  
             *When Enemies are generated
             *  -Either have them spawn based off of random numbers or have it based on number of levels completed
             *  - 
             * 
             * 
             */

            /****add a switch case statement, return an array from creating a game of characters to be placed, should return in order of placement***/
            //Create Hero 1
            grid[0, 0] = new Warrior("Warrior3");
            grid[0, 0].Location = new Point(100, 50);
            grid[0, 0].CharacterClick += new EventHandler(AttackCharacter);
            this.Controls.Add(grid[0, 0]);


            //Create Hero 2
            grid[0, 1] = new Cleric("Cleric2");
            grid[0, 1].Location = new Point(100, 175);
            grid[0, 1].CharacterClick += new EventHandler(AttackCharacter);
            this.Controls.Add(grid[0, 1]);

            ////Create Hero 3
            grid[0, 2] = new Mage("Mage3");
            grid[0, 2].Location = new Point(100, 300);
            grid[0, 2].CharacterClick += new EventHandler(AttackCharacter);
            this.Controls.Add(grid[0, 2]);

            //Create Enemy 1
            grid[1, 0] = new Bandit("Bandit1");
            grid[1, 0].Location = new Point(550, 50);
            grid[1, 0].CharacterClick += new EventHandler(AttackCharacter);
            this.Controls.Add(grid[1, 0]);

            ////Create Enemy 2
            grid[1, 1] = new Dragon("Dragon2");
            grid[1, 1].Location = new Point(550, 175);
            grid[1, 1].CharacterClick += new EventHandler(AttackCharacter);
            this.Controls.Add(grid[1, 1]);

            ////Create Enemy 3
            grid[1, 2] = new Ogre("CharacterKommon");
            grid[1, 2].Location = new Point(550, 300);
            grid[1, 2].CharacterClick += new EventHandler(AttackCharacter);
            this.Controls.Add(grid[1, 2]);
            /*
             * 
             * 
             * Debugging Purposes, Console Print out of various characters to check override methods/properties
             * 
             * 
             * 
             * 
             */
            //Thread.Sleep(100000);
            //Game game = new OperationDungeon.Game(grid);

            characterList?.Add(grid[0, 0]);
            characterList?.Add(grid[0, 1]);
            characterList?.Add(grid[0, 2]);
            characterList?.Add(grid[1, 0]);
            characterList?.Add(grid[1, 1]);
            characterList?.Add(grid[1, 2]);

            //Line required to erase the empty items in the characterList
            characterList = characterList.Where(s => !string.IsNullOrWhiteSpace(Convert.ToString(s))).Distinct().ToList();
           
            Console.WriteLine($"Warrior Speed = : {grid[0,0].Speed} Should be 2");
            //Console.WriteLine($"Character Speed = : {grid[0, 1].Speed} Should be 0");



        }

        public void CheckNumEnemies(List<Character> checkList)
        {
            for(int q = 0; q < checkList.Count(); q++)
            {
                string tempCheck = checkList[q].GetType().BaseType.ToString();
                tempCheck = tempCheck.Split('.')[1];
                if (tempCheck == "Enemy")
                {
                    numEnemies++;
                }
                else
                {
                    numHeroes++;
                }
            }
            MessageBox.Show($"Number of enemies = {numEnemies}, heroes = {numHeroes}");
            
        }
        //Method responsible for choosing the next player in line
        public Character Next()
        {
            //temporary variables used to find the next character
            int temp = 100;
            Character tempCharacter = new Character();

            //find the next player in the queue, or lowest turnCount left
            Console.WriteLine($"Before the for loop Count = {characterList.Count()}");
            //Find the character with the smallest turnCount

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
            flag = true;
            tempCharacter.panel1.BackColor = Color.Red;
            return tempCharacter;
        }
        public void CheckDeath(Character characterToLive)
        {
            //characterList.Remove(characterToLive);
            if (characterToLive.IsDead == true)
            {
                //MessageBox.Show($"Character who died is {characterToLive.CharacterName}");
                eventTextbox.AppendText($"{characterToLive.CharacterName} has died.");
                for (int i = 0; i < characterList.Count(); i++)
                {
                    if (characterList[i].CharacterName == characterToLive.CharacterName)
                    {
                        Console.WriteLine($"{characterList[i].CharacterName} = {characterToLive.CharacterName}");
                        //MessageBox.Show($"Character Erased. Count before{characterList.Count()}");
                        if (characterToLive.GetType().BaseType.ToString() == "OperationDungeon.Enemy")
                        {
                            numEnemies--;
                            //If statement to check if the game is over after killing the enemy. This will need to change to a point where it will happen whether
                            //the character is an enemy or hero
                            if (numEnemies == 0)
                            {
                                eventTextbox.AppendText("Player has completed the round");
                                MessageBox.Show("Congrats on winning the game");
                                this.Close();
                            }

                        }
                        else
                        {
                            numHeroes--;
                            //If statement to check if the game is over after killing the enemy. This will need to change to a point where it will happen whether
                            //the character is an enemy or hero
                            if (numHeroes == 0)
                            {
                                eventTextbox.AppendText("Player has Lost the round");
                                MessageBox.Show("You have lost the game! Thanks for playing! The Game will Close now.");
                                this.Close();
                            }
                        }
                        characterList.Remove(characterToLive);
                        eventTextbox.AppendText($"Heroes={numHeroes} Enemies={numEnemies} \n");
                        //MessageBox.Show($"Character Erased. Count After{characterList.Count()}");
                    }
                }
            }
        }
        public void AttackCharacter(object sender, EventArgs e)
        {
            Console.WriteLine("Attack Character Ran");
            Character c = (Character)sender;
            //c.Health = c.Health - 20;
            if (flag)
            {
                //flag is true, Next has been ran and the flag is set to true
                flag = false;
            }
            else
            {
                nextCharacter = Next();

            }
            //MessageBox.Show($"character attacking is: {nextCharacter.CharacterName}");
            Console.WriteLine($"Next in line is {nextCharacter.CharacterName} with the lowest turnCount of {nextCharacter.TurnCount}");




            //Decide if its either a hero or enemy
            string tempBase = Convert.ToString(c.GetType().BaseType);
            Console.WriteLine($"Attack Ran. character {c.CharacterName} is of type {tempBase}");
            tempBase = tempBase.Split('.')[1];
            Console.WriteLine($"tempBase after split = {tempBase}");
            //end hero/enemy check
            string nextCharacterBase = Convert.ToString(nextCharacter.GetType().BaseType);
            nextCharacterBase = nextCharacterBase.Split('.')[1];
            //MessageBox.Show($"tempBase: {tempBase} - nextCharacterBaese: {nextCharacterBase}");
            if (tempBase != nextCharacterBase)
            {
                //If they are not on the same team, attack
                //MessageBox.Show("person clicked is not on the same team.");
            }
            else
            {
                MessageBox.Show("Sorry you cannot click someone that is on your team ");
                flag = true;
                //AttackCharacter(sender,e);
                //nextCharacter = Next();
                return;
            }

            //Now we attack the player that has been clicked with the Attack stats of the character with the lowest turnCount
            int[] tempAttack = nextCharacter.Attack();
            int tempStrength = tempAttack[0];
            int tempIntelligence = tempAttack[1];
            c.Defense(tempStrength, tempIntelligence);
            eventTextbox.AppendText($"Character: {c.CharacterName} was attacked by {nextCharacter.CharacterName}. Intelligence: {tempIntelligence} Strength: {tempStrength} with {tempStrength + tempIntelligence} attack \n");
            //adjust the turn counts
            for (int t = 0; t < characterList.Count(); t++)
            {
               if(nextCharacter == characterList[t])
                {
                    characterList[t].TurnCount = nextCharacter.Speed;
                }
                else
                {
                    characterList[t].TurnCount--;
                }
            }
            //MessageBox.Show("Changing color back to normal"); 
            nextCharacter.panel1.BackColor = SystemColors.Control;
            //MessageBox.Show($"Checking death of {c.CharacterName}");
            CheckDeath(c);
            nextCharacter = Next();
        }
       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the Form/Game if the Exit button is clicked
            this.Close();
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stats stats = new OperationDungeon.Stats();
            stats.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadCharacters();
            nextCharacter = Next();
            CheckNumEnemies(characterList);
        }

        private void character_load(object sender, EventArgs e)
        {

        }

        private void startGameButton_Click(object sender, EventArgs e)
        {

        }
    }
}
