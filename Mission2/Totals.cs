using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2
{
    // This class will be used to loop through the array of totals and calcute the percent of roles
    class Totals
    {
        public double[] TotalCounts(int[] diceArray, int diceRolls)
        {
            int total2 = 0, total3 = 0, total4 = 0, total5 = 0, total6 = 0, total7 = 0, total8 = 0, total9 = 0, total10 = 0, total11 = 0, total12 = 0;
            for (int count = 0; count < diceRolls; count++)
            {
                int specificDiceCount = diceArray[count];
                switch (specificDiceCount)
                {
                    case 2:
                        total2++;
                        break;
                    case 3:
                        total3++;
                        break;
                    case 4:
                        total4++;
                        break;
                    case 5:
                        total5++;
                        break;
                    case 6:
                        total6++;
                        break;
                    case 7:
                        total7++;
                        break;
                    case 8:
                        total8++;
                        break;
                    case 9:
                        total9++;
                        break;
                    case 10:
                        total10++;
                        break;
                    case 11:
                        total11++;
                        break;
                    case 12:
                        total12++;
                        break;
                }
            }

            // calculate totals
            double final2 = (((double)total2 / diceRolls) * 100);
            final2 = Math.Round(final2);
            double final3 = (((double)total3 / diceRolls) * 100);
            final3 = Math.Round(final3);
            double final4 = (((double)total4 / diceRolls) * 100);
            final4 = Math.Round(final4);
            double final5 = (((double)total5 / diceRolls) * 100);
            final5 = Math.Round(final5);
            double final6 = (((double)total6 / diceRolls) * 100);
            final6 = Math.Round(final6);
            double final7 = (((double)total7 / diceRolls) * 100);
            final7 = Math.Round(final7);
            double final8 = (((double)total8 / diceRolls) * 100);
            final8 = Math.Round(final8);
            double final9 = (((double)total9 / diceRolls) * 100);
            final9 = Math.Round(final9);
            double final10 = (((double)total10 / diceRolls) * 100);
            final10 = Math.Round(final10);
            double final11 = (((double)total11 / diceRolls) * 100);
            final11 = Math.Round(final11);
            double final12 = (((double)total12 / diceRolls) * 100);
            final12 = Math.Round(final12);

            double[] finalArray = { final2, final3, final4, final5, final6, final7, final8, final9, final10, final11, final12 };
            return finalArray;
        }
    }
}
