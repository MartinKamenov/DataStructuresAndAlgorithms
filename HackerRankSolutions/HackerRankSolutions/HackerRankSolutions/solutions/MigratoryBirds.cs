using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class MigratoryBirds
    {
        public static int Solve()
        {
            List<int> arr = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int[] memo = new int[20000];

            for (int i = 0; i < arr.Count; i++)
            {
                memo[arr[i]]++;
            }

            int maxNumber = 0;
            int index = 0;

            for (int i = 0; i < memo.Length; i++)
            {
                if (memo[i] == 0)
                {
                    continue;
                }

                if (maxNumber < memo[i])
                {
                    maxNumber = memo[i];
                    index = i;
                }
            }

            return index;
        }
    }
}
