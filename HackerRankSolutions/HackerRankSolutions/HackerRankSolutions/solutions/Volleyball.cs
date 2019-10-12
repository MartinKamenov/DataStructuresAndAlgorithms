using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class Volleyball
    {
        public static void Solve()
        {
            string leap = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            float totalSaturdays = ((48 * 3) / 4) - h;
            float totalSundays = h;
            float machesDuringWeek = 5 * 2 / 3;
            float total = totalSaturdays + totalSundays + machesDuringWeek;

            if (leap == "leap")
            {
                total = total * 115 / 100;
            }

            Console.WriteLine(total);
        }
    }
}
