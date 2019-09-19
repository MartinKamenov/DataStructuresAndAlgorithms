using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class SimpleArraySum
    {
        public static int Solve(int[] ar)
        {
            int sum = 0;

            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }

            return sum;
        }
    }
}
