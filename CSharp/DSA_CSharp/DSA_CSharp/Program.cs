using DSA_CSharp.src.Linked_Lists;
using DSA_CSharp.src.Sorting;
using System;

namespace DSA_CSharp
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = new int[] { 2, 10, 15, 6, 0, -5, 3, 255, -1000 };

            int[] sortedNumbers = QuickSort<int>.QuickSortFunction(numbers);

            Console.WriteLine(string.Join(" ", sortedNumbers));
        }
    }
}
