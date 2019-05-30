using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.src.Sorting
{
    public class QuickSort<T> where T : IComparable
    {
        /*
            QuickSort sort selects a pivot and allocates two arrays. 
            One that than has smaller values than pivot and one that has bigger.
            Afterwards it does this recursively until only one element is left.
            Then we return an array with the concatednated smaller and bigger than pivot arrays and the pivot at between.
        */
        /// <summary>
        /// Uses quick sort to sort elements in array
        /// </summary>

        public static T[] QuickSortFunction(T[] array) 
        {
            if (array.Length <= 1)
            {
                return array;
            }

            T pivot = array[0];

            List<T> left = new List<T>();
            List<T> right = new List<T>();

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(pivot) <= 0)
                {
                    left.Add(array[i]);
                }
                else
                {
                    right.Add(array[i]);
                }
            }

            T[] sortedLeft = QuickSortFunction(left.ToArray());
            T[] sortedRight = QuickSortFunction(right.ToArray());

            T[] finalArr = new T[sortedLeft.Length + sortedRight.Length + 1];

            sortedLeft.CopyTo(finalArr, 0);
            finalArr[sortedLeft.Length] = pivot;
            sortedRight.CopyTo(finalArr, sortedLeft.Length + 1);
            return finalArr;
        }
    }
}
