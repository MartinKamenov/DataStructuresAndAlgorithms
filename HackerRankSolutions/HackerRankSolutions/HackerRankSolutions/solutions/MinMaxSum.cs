using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class MinMaxSum
    {
        public static void Execute()
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            Array.Sort(arr);

            long minSum = 0;
            long maxSum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < 4)
                {
                    minSum += arr[i];
                }

                if (i != 0)
                {
                    maxSum += arr[i];
                }
            }

            Console.WriteLine(minSum + " " + maxSum);
        }
    }
}
