using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class AVeryVeryBigSum
    {
        public static long AVeryBigSum(long[] ar)
        {
            long res = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                res += ar[i];
            }

            return res;
        }

        public static void Execute()
        {
            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp));
            long result = AVeryBigSum(ar);

            Console.WriteLine(result);
        }
    }
}
