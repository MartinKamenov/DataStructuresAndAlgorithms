using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class BreakingTheRecords
    {
        public static int[] Solve()
        {
            Console.ReadLine();
            int[] scores = Console.ReadLine()
                .Split(' ').Select(int.Parse)
                .ToArray();

            int min = scores[0];
            int max = scores[0];
            int[] changes = new int[] { 0, 0 };

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] < min)
                {
                    changes[1]++;
                    min = scores[i];
                }

                if (scores[i] > max)
                {
                    changes[0]++;
                    max = scores[i];
                }
            }

            return changes;
        }
    }
}
