using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class DiagonalDifference
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }

            int firstDSum = 0;
            int secondDSum = 0;

            for (int i = 0; i < n; i++)
            {
                firstDSum += arr[i][i];
                secondDSum += arr[i][n - i - 1];
            }

            Console.WriteLine(Math.Abs(firstDSum - secondDSum));
        }
    }
}
