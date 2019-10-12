using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class CoinsForChange
    {
        public static void Solve()
        {
            int change = int.Parse(Console.ReadLine());
            int[] coins = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };

            int[] result = new int[coins.Length];

            int index = 0;

            while (change > 0)
            {
                if (change - coins[index] < 0)
                {
                    index++;
                    continue;
                }

                change -= coins[index];
                result[index]++;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
