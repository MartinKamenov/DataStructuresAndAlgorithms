using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    public class TimeConversion
    {
        public static string Solve()
        {
            string s = Console.ReadLine();

            DateTime parsedDate = DateTime.Parse(s);

            string result= string.Format("{0:00}:{1:00}:{2:00}",
                parsedDate.Hour, parsedDate.Minute, parsedDate.Second);

            return result;
        }
    }
}
