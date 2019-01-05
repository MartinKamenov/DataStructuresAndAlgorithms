using System;

namespace HackerRankSolutions.solutions
{
    public class FormingAMagicSquare
    {
        public static int formingMagicSquare(int[][] s)
        {
            int[] numbers = new int[9];
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s[i].Length; j++)
                {
                    numbers[s[i][j]]++;
                }
            }

            int lastZero = -1;
            int lastBigger = -1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    lastZero = i;
                }
                else if (numbers[i] > 1)
                {
                    lastBigger = i;
                }

                if (lastBigger != -1 && lastZero != -1)
                {
                    result += Math.Abs(lastBigger - lastZero);

                    numbers[lastZero]++;
                    numbers[lastBigger]--;

                    lastBigger = -1;
                    lastZero = -1;

                    i = -1;
                    continue;
                }
            }

            return result;
        }

        public static void Execute()
        {

            int[][] s = new int[3][];

            for (int i = 0; i < 3; i++)
            {
                s[i] = Array.ConvertAll(Console.ReadLine().Split(' '), sTemp => Convert.ToInt32(sTemp));
            }

            int result = formingMagicSquare(s);

            Console.WriteLine(result);
        }
    }
}
