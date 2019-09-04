using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class BirthdayCakeCandles
    {
        public static int Execute()
        {
            Console.ReadLine();
            int[] ar = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            Array.Sort(ar);
            Array.Reverse(ar);

            int lastNumber = ar[0];
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] != lastNumber)
                {
                    return i;
                }

                lastNumber = ar[i];
            }

            return ar.Length;
        }
    }
}
