﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.src.Sorting
{
    public class MergeSort<T> where T:IComparable
    {
        public static T[] MergeSortWithoutAllocatingArray(int start, int end, T[] arr)
        {
            if (end - start <= 1)
            {
                return arr;
            }

            int middle = start + ((end - start) / 2);

            MergeSortWithoutAllocatingArray(start, middle, arr);
            MergeSortWithoutAllocatingArray(middle, end, arr);

            int leftIndex = 0;
            int rightIndex = 0;

            T[] sortedArr = new T[end - start];

            while (leftIndex < middle - start || rightIndex < end - middle)
            {
                if (leftIndex < middle - start && rightIndex < end - middle)
                {
                    if (arr[start + leftIndex].CompareTo(arr[middle + rightIndex]) >= 0)
                    {
                        sortedArr[leftIndex + rightIndex] = arr[start + leftIndex];
                        leftIndex++;
                    }
                    else
                    {
                        sortedArr[leftIndex + rightIndex] = arr[middle + rightIndex];
                        rightIndex++;
                    }
                    continue;
                }
                else if (leftIndex < middle - start)
                {
                    sortedArr[leftIndex + rightIndex] = arr[start + leftIndex];
                    leftIndex++;
                }
                else
                {
                    sortedArr[leftIndex + rightIndex] = arr[middle + rightIndex];
                    rightIndex++;
                }
            }

            for (int i = 0; i < sortedArr.Length; i++)
            {
                arr[start + i] = sortedArr[i];
            }

            return arr;
        }
    }
}