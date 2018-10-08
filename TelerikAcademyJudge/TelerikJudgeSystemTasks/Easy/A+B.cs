using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TelerikJudgeSystemTasks.Contracts;

namespace TelerikJudgeSystemTasks.Easy
{
    public class APlusB : ITask
    {
        public void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int sum = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum += numbers[j];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
