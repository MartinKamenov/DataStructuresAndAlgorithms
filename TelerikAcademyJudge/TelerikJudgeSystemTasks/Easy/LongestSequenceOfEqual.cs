using System;
using TelerikJudgeSystemTasks.Contracts;

namespace TelerikJudgeSystemTasks.Easy
{
    public class LongestSequenceOfEqual : ITask
    {
        public void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            int maxSize = 1;
            int size = 1;
            int prevNum = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int nexNum = int.Parse(Console.ReadLine());
                if (prevNum == nexNum && i != (n - 1))
                {
                    size++;
                }
                else
                {
                    if (prevNum == nexNum)
                    {
                        size++;
                    }
                    if (size > maxSize)
                    {
                        maxSize = size;
                    }

                    size = 1;
                    prevNum = nexNum;
                }
            }

            Console.WriteLine(maxSize);
        }
    }
}
