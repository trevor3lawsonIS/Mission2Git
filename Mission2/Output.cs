using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2
{
    // This class will print out the final results
    class Output
    {
        public void Print(double[] finalArray)
        {
            string final2String = new string('*', (int)finalArray[0]);
            Console.WriteLine("2: " + final2String);
            string final3String = new string('*', (int)finalArray[1]);
            Console.WriteLine("3: " + final3String);
            string final4String = new string('*', (int)finalArray[2]);
            Console.WriteLine("4: " + final4String);
            string final5String = new string('*', (int)finalArray[3]);
            Console.WriteLine("5: " + final5String);
            string final6String = new string('*', (int)finalArray[4]);
            Console.WriteLine("6: " + final6String);
            string final7String = new string('*', (int)finalArray[5]);
            Console.WriteLine("7: " + final7String);
            string final8String = new string('*', (int)finalArray[6]);
            Console.WriteLine("8: " + final8String);
            string final9String = new string('*', (int)finalArray[7]);
            Console.WriteLine("9: " + final9String);
            string final10String = new string('*', (int)finalArray[8]);
            Console.WriteLine("10: " + final10String);
            string final11String = new string('*', (int)finalArray[9]);
            Console.WriteLine("11: " + final11String);
            string final12String = new string('*', (int)finalArray[10]);
            Console.WriteLine("12: " + final12String);

            Console.WriteLine("\n" + "Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
