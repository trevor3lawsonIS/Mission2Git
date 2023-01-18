using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Author: Trevor Lawson
            // Description: This program will simulate the throwing of two dice, and keep track of their totals


            // start of program, gather necessary info
            Console.WriteLine("Welcome to the dice throwing simulator!" + "\n");
            Console.Write("How many dice rolls would you like to simulate?" + "\t");
            int diceRolls = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n" + "DICE ROLLING SIMULATION RESULTS" + "\n");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + diceRolls + "\n");

            // this will get your two random numbers between 1-6
            random_numbers rn = new random_numbers();
            int[] diceArray = rn.RandomNumber(diceRolls);

            // this will keep track of the totals for all options
            Totals totals = new Totals();
            double[] finalArray = totals.TotalCounts(diceArray, diceRolls);

            // Print final results
            Output output = new Output();
            output.Print(finalArray);

        }
    }
}
