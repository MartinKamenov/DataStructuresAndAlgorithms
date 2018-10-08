using System;
using TelerikJudgeSystemTasks.Contracts;

namespace TelerikJudgeSystemTasks.Easy
{
    public class BiggestPrimeNumber : ITask
    {
        public void Execute()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        public bool IsPrime(int number)
        {
            if (number < 3)
            {
                return true;
            }

            for (int i = 2; i < Math.Sqrt(number) + 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
