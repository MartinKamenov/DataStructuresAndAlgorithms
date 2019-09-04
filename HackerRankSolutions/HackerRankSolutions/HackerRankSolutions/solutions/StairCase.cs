using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    class StairCase
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= n - i - 2)
                    {
                        result.Append(" ");
                    }
                    else
                    {
                        result.Append("#");
                    }
                }

                result.Append("\n");
            }

            
            Console.WriteLine(result.ToString());
        }
    }
}
