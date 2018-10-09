using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikJudgeSystemTasks.Contracts;

namespace TelerikJudgeSystemTasks.Easy
{
    public class MaxSumOfKElements : ITask
    {
        public void Execute()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] sorted = MergeSort(arr);
            int sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += sorted[i];
            }

            Console.WriteLine(sum);
        }

        public static int[] MergeSort(int[] arr)
        {
            if (arr.Length == 1)
            {
                return arr;
            }

            int middle = arr.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[arr.Length - middle];
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < middle)
                {
                    left[i] = arr[i];
                }
                else
                {
                    right[i - middle] = arr[i];
                }
            }

            int[] sortedLeft = MergeSort(left);
            int[] sortedRight = MergeSort(right);
            int leftIndex = 0;
            int rightIndex = 0;
            int[] sortedArr = new int[arr.Length];
            while (leftIndex < sortedLeft.Length || rightIndex < sortedRight.Length)
            {
                // The >= logical operator makes the sorting stable
                if (leftIndex < sortedLeft.Length && rightIndex < sortedRight.Length
                    && sortedLeft[leftIndex] >= sortedRight[rightIndex])
                {
                    sortedArr[leftIndex + rightIndex] = sortedLeft[leftIndex++];
                }
                else if (leftIndex < sortedLeft.Length && rightIndex < sortedRight.Length)
                {
                    sortedArr[leftIndex + rightIndex] = sortedRight[rightIndex++];
                }
                else if (leftIndex == sortedLeft.Length)
                {
                    sortedArr[leftIndex + rightIndex] = sortedRight[rightIndex++];
                }
                else
                {
                    sortedArr[leftIndex + rightIndex] = sortedLeft[leftIndex++];
                }
            }

            return sortedArr;
        }
    }
}
