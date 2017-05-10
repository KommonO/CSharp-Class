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
        string[] selectedHeroArray;

        public Form1(string[] initHeroArray)
        {
            InitializeComponent();
            selectedHeroArray = initHeroArray;
        }

        
        private void LoadCharacters()
        {

            //Decide placement of heroes based on user selection
            for(int i = 0; i < selectedHeroArray.Count(); i++)
            {
                if(selectedHeroArray[i] == "Warrior")
                {
                    grid[0, i] = new Warrior("Warrior"); // Generic names, would have added a textbox,if time allowed, for user to enter character names

                }
                else if (selectedHeroArray[i] == "Mage")
                {
                    grid[0, i] = new Mage("Mage");
                }
                else if (selectedHeroArray[i] == "Cleric")
                {
                    grid[0, i] = new Cleric("Cleric");
                }
                else
                {
                    grid[0, i] = null;
                }
            }
            //Place Hero 1, if applicable
            try
            {
                grid[0, 0].Location = new Point(100, 50);
                grid[0, 0].CharacterClick += new EventHandler(AttackCharacter);
                this.Controls.Add(grid[0, 0]);
            }
            catch
            {

            }
            //Place Hero 2, if applicable
            try
            {
                grid[0, 1].Location = new Point(100, 175);
                grid[0, 1].CharacterClick += new EventHandler(AttackCharacter);
                this.Controls.Add(grid[0, 1]);
            }
            catch
            {

            }
            //Place Hero 3, if applicable
            try
            {
                grid[0, 2].Location = new Point(100, 300);
                grid[0, 2].CharacterClick += new EventHandler(AttackCharacter);
                this.Controls.Add(grid[0, 2]);
            }
            catch
            {

            }
            Random rnd2 = new Random();
            int numEnemies = rnd2.Next(1, 4);
            Random rnd = new Random();
            //Plans would have been to write this code to generate a random number of enemies,
            //As well as selecting random enemies per position
            for (int j = 0; j< numEnemies; j++)
            {
                
                int randEnemy = rnd.Next(1, 4);
                if (randEnemy == 1)
                {
                    //Create Enemy 1
                    grid[1, j] = new Bandit("Bandit");
                    
                }
                if (randEnemy == 2)
                {
                    //Create Enemy 2
                    grid[1, j] = new Dragon("Dragon");
                   
                }

                if (randEnemy == 3)
                {
                    ////Create Enemy 3
                    grid[1, j] = new Ogre("Ogre");
                    
                }
            }
            //Place enemy 1 if applicable
            try
            {
                grid[1, 0].Location = new Point(450, 50);
                grid[1, 0].CharacterClick += new EventHandler(AttackCharacter);
                this.Controls.Add(grid[1, 0]);
            }
            catch
            {

            }
            //Place Enemy 2, if applicable
            try
            {
                grid[1, 1].Location = new Point(450, 175);
                grid[1, 1].CharacterClick += new EventHandler(AttackCharacter);
                this.Controls.Add(grid[1, 1]);
            }
            catch
            {

            }
            //Place Enemy 3, if applicable
            try
            {
                grid[1, 2].Location = new Point(450, 300);
                grid[1, 2].CharacterClick += new EventHandler(AttackCharacter);
                this.Controls.Add(grid[1, 2]);
            }
            catch
            {

            }





            characterList?.Add(grid[0, 0]);
            characterList?.Add(grid[0, 1]);
            characterList?.Add(grid[0, 2]);
            characterList?.Add(grid[1, 0]);
            characterList?.Add(grid[1, 1]);
            characterList?.Add(grid[1, 2]);

            //Line required to erase the empty items in the characterList
            characterList = characterList.Where(s => !string.IsNullOrWhiteSpace(Convert.ToString(s))).Distinct().ToList();
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
            //MessageBox.Show($"Number of enemies = {numEnemies}, heroes = {numHeroes}");
            
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
            SetBackground(tempCharacter);
            tempCharacter.chooseAttackComboBox.Visible = true;
            tempCharacter.chooseAttackLabel.Visible = true;
            return tempCharacter;
        }
        public void SetBackground(Character backgroundCharacter)
        {
            string characterType = backgroundCharacter.GetType().ToString();
            characterType = characterType.Split('.')[1];
            Console.WriteLine($"string = {characterType} before split");
            switch (characterType){ 
                case "Warrior":
                    Console.WriteLine("Character to background change = Warrior");
                    backgroundCharacter.panel1.BackgroundImage = System.Drawing.Image.FromFile(@"Backgrounds/Warrior_Background.png");
                    break;
                case "Mage":
                    Console.WriteLine("Character to background change = Mage");
                    backgroundCharacter.panel1.BackgroundImage = System.Drawing.Image.FromFile(@"Backgrounds/Mage_Background.png");
                    break;
                case "Cleric":
                    Console.WriteLine("Character to background change = Cleric");
                    backgroundCharacter.panel1.BackgroundImage = System.Drawing.Image.FromFile(@"Backgrounds/Cleric_Background.png");
                    break;
                case "Bandit":
                    Console.WriteLine("Character to background change = Bandit");
                    backgroundCharacter.panel1.BackgroundImage = System.Drawing.Image.FromFile(@"Backgrounds/Bandit_Background3.png");
                    break;
                case "Dragon":
                    Console.WriteLine("Character to background change = Dragon");
                    backgroundCharacter.panel1.BackgroundImage = System.Drawing.Image.FromFile(@"Backgrounds/Dragon_Background.png");
                    break;
                case "Ogre":
                    Console.WriteLine("Character to background change = Ogre");
                    backgroundCharacter.panel1.BackgroundImage = System.Drawing.Image.FromFile(@"Backgrounds/Ogre_Background.png");
                    break;
            }

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
                                var restart = MessageBox.Show("You have defeated the horde of enemies! Would you like to play the next level?", "Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if(restart == DialogResult.Yes)
                                {
                                    Application.Restart();
                                }
                                else if(restart == DialogResult.No)
                                {
                                    this.Close();
                                }
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
                                var restart = MessageBox.Show("All of your characters have died! Would you like to try again?", "Message", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                                if (restart == DialogResult.Retry)
                                {
                                    Application.Restart();
                                }
                                else if (restart == DialogResult.Cancel)
                                {
                                    this.Close();
                                }
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
            tempBase = tempBase.Split('.')[1];
            string nextCharacterBase = Convert.ToString(nextCharacter.GetType().BaseType);
            nextCharacterBase = nextCharacterBase.Split('.')[1];
            if (tempBase != nextCharacterBase)
            {
                //If they are not on the same team, attack
                //MessageBox.Show("person clicked is not on the same team.");
                //Now we attack the player that has been clicked with the Attack stats of the character with the lowest turnCount
                int attackType = 0;
                int[] tempAttack = nextCharacter.Attack(attackType);
                int tempStrength = tempAttack[0];
                int tempIntelligence = tempAttack[1];
                c.Defense(tempStrength, tempIntelligence);
                nextCharacter.SkillPoints = nextCharacter.SkillPoints + 25;
                eventTextbox.AppendText($"Character: {c.CharacterName} was attacked by {nextCharacter.CharacterName}. Intelligence: {tempIntelligence} Strength: {tempStrength} with {tempStrength + tempIntelligence} attack. New Skill Points:{nextCharacter.SkillPoints} \n");
            }
            else
            {
                //If they are on the same team. Check if it is the Clerik's turn and heal if so
                if (nextCharacter.GetType().ToString() == "OperationDungeon.Cleric")
                {
                    int attackType = 0;
                    int[] tempAttack = nextCharacter.Attack(attackType);
                    int tempStrength = 0 - tempAttack[0];
                    int tempIntelligence = 0 - tempAttack[1];
                    c.Defense(tempStrength, tempIntelligence);
                    nextCharacter.SkillPoints = nextCharacter.SkillPoints + 25;
                    eventTextbox.AppendText($"Character: {c.CharacterName} was healed by {nextCharacter.CharacterName}. Intelligence: {tempIntelligence} Strength: {tempStrength} with {tempStrength + tempIntelligence} attack. New Skill Points:{nextCharacter.SkillPoints} \n");
                }
                else
                {
                    MessageBox.Show("Sorry you cannot click someone that is on your team! Unless you are a Cleric!");
                    flag = true;
                    return;
                }
            }
            //adjust the turn counts
            for (int t = 0; t < characterList.Count(); t++)
            {
                if (nextCharacter == characterList[t])
                {
                    characterList[t].TurnCount = nextCharacter.Speed;
                }
                else
                {
                    characterList[t].TurnCount--;
                }
            }
            nextCharacter.panel1.BackgroundImage = null;
            nextCharacter.chooseAttackComboBox.Visible = false;
            nextCharacter.chooseAttackLabel.Visible = false;
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

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
