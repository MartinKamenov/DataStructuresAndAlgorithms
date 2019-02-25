using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.src.Linear_Structures.Queue
{
    public class Queue<T> : IQueue<T>
    {
        private T[] array;
        private const int INITIAL_SIZE = 4;
        private int size;

        public Queue()
        {
            size = 0;
            array = new T[INITIAL_SIZE];
        }

        public void Add(T value)
        {
            array[size++] = value;
            extendIfNeeded();
        }

        public T Remove()
        {
            T firstElement = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[array.Length - 1] = default(T);
            size--;

            return firstElement;
        }

        private bool extendIfNeeded()
        {
            bool shouldExtend = shouldExtendSize(size, array.Length);
            if (shouldExtend)
            {
                T[] newArray = new T[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }

                array = newArray;
            }

            return shouldExtend;
        }

        private bool shouldExtendSize(int index, int arraySize)
        {
            return index >= arraySize;
        }
    }
}
