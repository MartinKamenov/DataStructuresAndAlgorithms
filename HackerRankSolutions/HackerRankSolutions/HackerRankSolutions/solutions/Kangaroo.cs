using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class Kangaroo
    {
        public static string Solve()
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            if (v1 <= v2)
            {
                return "NO";
            }

            while (x1 < x2)
            {
                x1 += v1;
                x2 += v2;
            }

            if (x1 == x2)
            {
                return "YES";
            }
            else
            {
                return"NO";
            }
        }
    }
}
