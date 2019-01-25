namespace DSA_CSharp.src.Sorting
{
    public class CountingSort
    {
        public static int[] CountingSortFunction(int[] array, int max)
        {
            int[] counts = new int[max + 1];

            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i]]++;
            }

            int[] sorted = new int[array.Length];
            int index = 0;

            for (int i = 0; i < max + 1; i++)
            {
                for (int j = 0; j < counts[i]; j++)
                {
                    sorted[index++] = i;
                }
            }

            return sorted;
        }
    }
}
