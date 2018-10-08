using System;
using TelerikJudgeSystemTasks.Contracts;

namespace TelerikJudgeSystemTasks.Easy
{
    class AllocateArray : ITask
    {
        public void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}
