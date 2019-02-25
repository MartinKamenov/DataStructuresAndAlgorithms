using DSA_CSharp.src.Linear_Structures.Queue;
using System;

namespace DSA_CSharp
{
    public class Program
    {
        public static void Main()
        {
            var queue = new Queue<int>();

            for (int i = 0; i < 20; i++)
            {
                queue.Add(i + 1);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(queue.Remove());
            }

            queue.Add(1001);
            Console.WriteLine(queue.Remove());
        }
    }
}
