using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class PlusMinus
    {
        public static void Solve()
        {
            Console.ReadLine();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int negative = 0;
            int positive = 0;
            int neutral = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    negative++;
                }
                else if (arr[i] == 0)
                {
                    neutral++;
                }
                else
                {
                    positive++;
                }
            }

            Console.WriteLine("{0:0.000000}", (float)positive / arr.Length);
            Console.WriteLine("{0:0.000000}", (float)negative / arr.Length);
            Console.WriteLine("{0:0.000000}", (float)neutral / arr.Length);
        }
    }
}
