using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchandSort
{
    class Program
    {

        private static int[] InitializeArray()
        {
            int[] rndArray = new int[100];
            bool exists = false;
            //create an array of placed items
            int[] placedNumbers = new int[100];
            //Console.WriteLine($"rndArray size: {rndArray.Count()}");
            Random rnd = new Random();
            //Initialize values
            int temp;//= rnd.Next(1, 101);
            //for loop to count from 1 to 100 to loop through the random array
            for (int i = 0; i < 100; i++)
            {
                //in the for loop test if the random number has been chosen recently
                temp = rnd.Next(1, 101);
                //Console.WriteLine($"temp before check: {temp}");
                //Should give a range from 1 to 100
                for (int j = 0; j < rndArray.Count(); j++)
                {
                    //run through the placedNumbers array checking each index for the temp
                    if (rndArray[j] == temp)
                    {
                        //Console.WriteLine("the number already exists");
                        // the number has been placed
                        //Console.WriteLine($"exists before {exists}");
                        exists = true;
                        //Console.WriteLine($"exists after {exists}");
                        j = 100;

                    }
                    else
                    {
                        //the number has not been placed
                        //Console.WriteLine("the number does not exist");

                        //placedNumbers[j] = temp;
                        //j = 100;

                    }
                }
                if (exists)
                {
                    //Console.WriteLine($"An existing value was found! i before subtract {i}");
                    i--;
                    //exists = false;
                    //Console.WriteLine($"An existing value was found! i after subract {i}");
                }
                else
                {
                    rndArray[i] = temp;
                    //placedNumbers[i] = temp;
                    //Console.WriteLine($"temp: {temp} was not found and will be placed");
                    //Console.WriteLine($"placed value {temp} in rndArray at index {i}");
                }
                // do this by checking the array of placed items
                // if the array of placed items does not contain the random number, add it to the spot
                exists = false;

            }
            for (int z = 0; z < 100; z++)
            {
                //Console.WriteLine($"rndArray[{z}] = {rndArray[z]}");
            }
            //Console.WriteLine($"number of unique values: {rndArray.Distinct().Count()}");
            return rndArray;
        }

        static int[] CocktailSort(int[] inputArray)
        {
            int[] tempArray = new int[100];
            int[] sortedArray = new int[100];
            int numIterations = 0;
            //int startPointer = 0;
            //int endPointer = 99;
            //int leftPointer;
            //int rightPointer;
            //int firstValue = inputArray[startPointer];
            //int lastValue = inputArray[endPointer];
            //int leftValue = inputArray[0];
            //int rightValue = inputArray[1];
            bool swapped = false;
            do
            {
                for (int i = 0; i <= inputArray.Length - 2; i++)
                {
                    numIterations++;
                    if (inputArray[i] > inputArray[i+1])
                    {
                        swap(i, i + 1, ref inputArray);
                        swapped = true;
                        
                    }
                   
                }
                if (!swapped) { break; }
                swapped = false;
                for (int i = inputArray.Length - 2; i >= 0; i--)
                {
                    if (inputArray[i] > inputArray[i + 1])
                    {
                        swap(i, i + 1, ref inputArray);
                        swapped = true;
                    }
                    numIterations++;
                }
            }
            while (swapped);
            //System.IO.StreamWriter file = new System.IO.StreamWriter("iterations.txt");
            System.IO.File.AppendAllText(@"iterations.txt", Convert.ToString(numIterations) + "\n");
            Console.WriteLine($"Num of iterations: {numIterations} ");
            
            //file.WriteLine($"Num of iterations: {numIterations} ");
            //file.Close();
            return inputArray;
        }
        static void swap(int index1, int index2, ref int[] arr)
        {
            //Console.WriteLine($"arr size = {arr.Count()}");
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
           
        static int[] HeapSort(int[] inputArray)
        {
            int[] sortedArray = new int[100];

            return sortedArray;
        }
        static int AverageComparisons()
        {

            int average = 0;
            string[] lines = System.IO.File.ReadAllLines(@"iterations.txt");
            int total = 0;
            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("AverageComparisons number of iterations: ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
               total += Convert.ToInt32(line);
            }
            average = total / 100;
            Console.WriteLine($"average is {average}");
            return average;
        }
        static int TotalCost(int startNumber)
        {
            int totalCost = 0;
            int max = 100;
            int min = 0;
            Random rnd = new Random();
            bool found = false;
            int numGuesses = 0;
            int randomNumber = rnd.Next(1, 101);
            //int totalCost = 0;
            Console.WriteLine($"randomNumber:{randomNumber}");
            do
            {
                
                if (startNumber == randomNumber)
                {
                    numGuesses++;
                    totalCost += startNumber;
                    found = true;
                }
                else
                {
                    numGuesses++;
                    totalCost += startNumber;
                    if (startNumber > randomNumber)
                    {
                        Console.WriteLine($"startNumber:{startNumber} > randomNumber:{randomNumber}");
                        //guess is larger, go down
                        
                        max = startNumber;
                    }
                    else if(startNumber < randomNumber)
                    {
                        Console.WriteLine($"startNumber:{startNumber} < randomNumber:{randomNumber}");
                        //Go up
                        min = startNumber;
                    }
                    if((randomNumber == 100) && (startNumber == 99))
                    {
                        startNumber = 100;
                    }
                    else
                    {
                        startNumber = (max + min) / 2;
                    }
                    
                }
            }
            while (!found);
            Console.WriteLine($"Number of guesses: {numGuesses}");
            Console.WriteLine($"Total Cost: {totalCost}");
            return totalCost;
        }
        static int NumberOfGuesses(int startNumber)
        {
            int totalCost = 0;
            int max = 100;
            int min = 0;
            Random rnd = new Random();
            bool found = false;
            int numGuesses = 0;
            int randomNumber = rnd.Next(1, 101);
            //int totalCost = 0;
            Console.WriteLine($"randomNumber:{randomNumber}");
            do
            {

                if (startNumber == randomNumber)
                {
                    numGuesses++;
                    totalCost += startNumber;
                    found = true;
                }
                else
                {
                    numGuesses++;
                    totalCost += startNumber;
                    if (startNumber > randomNumber)
                    {
                        Console.WriteLine($"startNumber:{startNumber} > randomNumber:{randomNumber}");
                        //guess is larger, go down

                        max = startNumber;
                    }
                    else if (startNumber < randomNumber)
                    {
                        Console.WriteLine($"startNumber:{startNumber} < randomNumber:{randomNumber}");
                        //Go up
                        min = startNumber;
                    }
                    if ((randomNumber == 100) && (startNumber == 99))
                    {
                        startNumber = 100;
                    }
                    else
                    {
                        startNumber = (max + min) / 2;
                    }

                }
            }
            while (!found);
            Console.WriteLine($"Number of guesses: {numGuesses}");
            Console.WriteLine($"Total Cost: {totalCost}");
            return numGuesses;
        }
        static int AverageMinimumCost()
        {
            int minCost = 1000;
            int maxCost = 0;
            int averageIterations = 5;
            int averageCostMinIndex = 0;
            int[] averageCostArray = new int[100];
            System.IO.File.Delete(@"AverageGuessCosts.txt");
            for (int c = 1; c < 101; c++)
            {
                int guess = c;
                int total = 0;
                for (int l = 0; l < averageIterations; l++)
                {
                    total += TotalCost(guess);
                }
                averageCostArray[c - 1] = total / averageIterations;
                for (int p = 0; p < averageCostArray.Count(); p++)
                {
                    if (averageCostArray[p] == averageCostArray.Min())
                    {
                        averageCostMinIndex = p + 1;
                    }
                }
                Console.WriteLine("minimum of cost array = " + averageCostArray.Min() + "at start number:" + averageCostMinIndex);
                Console.WriteLine($"Average Cost of guess {c} = {averageCostArray[c - 1]}");

                System.IO.File.AppendAllText(@"AverageGuessCosts.txt", $"Average Cost of guess {c} = {averageCostArray[c - 1]}\n");
            }
            return averageCostMinIndex;
        }
        static int MinimumGuess()
        {
            int minCost = 1000;
            int maxCost = 0;
            int averageIterations = 5;
            int averageCostMinIndex = 0;
            int[] minimumGuessArray = new int[100];
            System.IO.File.Delete(@"MinimumGuessAverage.txt");
            for (int c = 1; c < 101; c++)
            {
                int guess = c;
                int total = 0;
                for (int l = 0; l < averageIterations; l++)
                {
                    total += NumberOfGuesses(guess);
                }
                minimumGuessArray[c - 1] = total / averageIterations;
                for (int p = 0; p < minimumGuessArray.Count(); p++)
                {
                    if (minimumGuessArray[p] == minimumGuessArray.Min())
                    {
                        averageCostMinIndex = p + 1;
                    }
                }
                Console.WriteLine("minimum number of Guesses = " + minimumGuessArray.Min() + "at start number:" + averageCostMinIndex);
                Console.WriteLine($"Average number of guesses for {c} = {minimumGuessArray[c - 1]}");

                System.IO.File.AppendAllText(@"MinimumGuessAverage.txt", $"Average minimum number of guesses {c} = {minimumGuessArray[c - 1]}\n");
            }
            return averageCostMinIndex;
        }
        static void Main(string[] args)
        {
            //Sorting
            //Part 1
            for(int i = 0; i < 100; i++)
            {
                int[] unsortedArray = InitializeArray();
                int[] sortedCocktailArray = CocktailSort(unsortedArray);
            }
            AverageComparisons();
            //Part 2
            //Average Cost: Finds the average Cost in the search algorithm
            Console.WriteLine("Part 1 Complete. Press Enter to continue onto part 2.");
            Console.ReadLine();
            Console.WriteLine("On average, the starting number with the smallest cost is:" + AverageMinimumCost());
            Console.WriteLine("Start number with minimum number of Guesses " + MinimumGuess());
            Console.WriteLine("Finished");
            
            Console.ReadLine();
        }
    }
}
