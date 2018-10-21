using DSA_CSharp.Linear_Structures.List;
using DSA_CSharp.src.Sorting;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] 
            {
                5, 25, 3, 45, 88, 12, 11, 13, 202, 103, 14
            };
            MergeSort<int>.MergeSortWithoutAllocatingArray(0, numbers.Length, numbers);

            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
