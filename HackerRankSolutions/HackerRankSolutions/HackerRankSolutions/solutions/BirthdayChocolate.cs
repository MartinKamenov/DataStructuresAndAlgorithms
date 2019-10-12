using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class BirthdayChocolate
    {
        public static int Solve()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> s = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int d = nums[0];
            int m = nums[1];

            int totalWays = 0;

            for (int i = 0; i < s.Count; i++)
            {
                int currentDays = 0;
                for (int j = i; j < (i + m) && j < s.Count; j++)
                {
                    currentDays += s[j];
                    if (currentDays == d && j == (i + m - 1))
                    {
                        totalWays++;
                        break;
                    }
                }
            }

            return totalWays;
        }
    }
}
