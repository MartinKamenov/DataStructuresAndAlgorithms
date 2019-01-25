using System;

namespace DSA_CSharp.src.Sorting
{
    public class BubbleSort<T> where T : IComparable
    {
        public static T[] BubbleSortFunction(T[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T var = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = var;
                    }
                }
            }

            return array;
        }
    }
}
