using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.solutions
{
    class GradingStudents
    {
        public static void Solve()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> grades = new List<int>();

            for (int i = 0; i < n; i++)
            {
                grades.Add(int.Parse(Console.ReadLine()));
            }

            for (int i = 0; i < grades.Count; i++)
            {
                if(grades[i] > 37 && grades[i] % 5 > 2)
                {
                    grades[i] += 5 - (grades[i] % 5);
                }
            }

            for (int i = 0; i < grades.Count; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }
    }
}
