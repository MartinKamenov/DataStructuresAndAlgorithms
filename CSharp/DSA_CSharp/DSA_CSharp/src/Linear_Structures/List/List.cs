using DSA_CSharp.Linear_Structures.List;
using System;
using System.Collections.Generic;
using System.Collections;

namespace DSA_CSharp.Linear_Structures.List
{
    public class List<T> : IList<T>
    {
        private T[] buffer;
        private const int DEFAULT_DATA_SIZE = 4;
        private const int DEFAULT_RESIZE_PERCENT = 75;
        private int count;

        public List()
        {
            buffer = new T[DEFAULT_DATA_SIZE];
            count = 0;
        }

        public T this[int index]
        {
            get
            {
                return buffer[index];
            }

            set
            {
                this.buffer[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T value)
        {
            this.buffer[count] = value;
            count++;
            if (ShouldResize())
            {
                Resize();
            }
        }

        public void Clear()
        {
            this.buffer = new T[DEFAULT_DATA_SIZE];
        }

        public bool Contains(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (buffer[i].Equals(value))
                {
                    return true;
                }
            }

            return false;
        }

        public int IndexOf(T value)
        {
            for (int i = 0; i < count; i++)
            {
                if (buffer[i].Equals(value))
                {
                    return i;
                }
            }

            return -1;
        }

        public void Insert(int index, T value)
        {
            for (int i = count; i > index; i--)
            {
                buffer[i] = buffer[i - 1];
            }

            buffer[index] = value;

            count++;

            if (ShouldResize())
            {
                Resize();
            }
        }

        public void Remove(T value)
        {
            bool hasBeenFound = false;
            int foundIndex = -1;
            for (int i = 0; i < count; i++)
            {
                if (!hasBeenFound && buffer[i].Equals(value))
                {
                    hasBeenFound = true;
                    foundIndex = i;
                    break;
                }
            }

            if (hasBeenFound)
            {
                SwapElementsAfteIndex(foundIndex);
            }
        }

        public void RemoveAt(int index)
        {
            SwapElementsAfteIndex(index);
        }

        private void SwapElementsAfteIndex(int index)
        {
            for (int i = index; i < count - 1; i++)
            {
                buffer[i] = buffer[i + 1];
            }
            buffer[count] = default(T);
            count--;
        }

        private bool ShouldResize()
        {
            // Checks if buffer is 75 percent full
            double nPercentsFromBuffer = (((double)this.buffer.Length) / 100) * DEFAULT_RESIZE_PERCENT;
            if (this.count + 1 > nPercentsFromBuffer)
            {
                return true;
            }

            return false;
        }

        private void Resize()
        {
            T[] newData = new T[this.buffer.Length * 2];
            for (int i = 0; i < count; i++)
            {
                newData[i] = this.buffer[i];
            }

            this.buffer = newData;
        }
    }
}