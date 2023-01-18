using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2
{
    class random_numbers
    {
        public int[] RandomNumber(int diceRolls)
        { 
        Random rnd = new Random();
        int[] diceArray = new int[diceRolls];
            for (int count = 0; count < diceRolls; count++)
            {
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                int diceTotal = dice1 + dice2;

                diceArray[count] = diceTotal;
            }
            return diceArray;
        }
}
}
