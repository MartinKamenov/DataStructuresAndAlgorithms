using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRankSolutions.solutions
{
    class CompareTheTriplets
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aResult = 0;
            int bResult = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    aResult++;
                }
                else if (a[i] < b[i])
                {
                    bResult++;
                }
            }

            List<int> result = new List<int>() { aResult, bResult };
            return result;
        }

        public static void Execute()
        {
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
    }
}
