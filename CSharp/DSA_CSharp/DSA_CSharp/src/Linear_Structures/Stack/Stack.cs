using DSA_CSharp.src.Linear_Structures.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.src.Linear_Structures.Stack
{
    public class Stack<T> : IStack<T>
    {
        private int count;
        private T[] buffer;
        private const int DEFAULT_DATA_SIZE = 4;
        private const int DEFAULT_RESIZE_PERCENT = 75;

        public Stack()
        {
            buffer = new T[DEFAULT_DATA_SIZE];
            count = 0;
        }
        public bool isEmpty()
        {
            return count == 0;
        }

        public T pop()
        {
            throw new NotImplementedException();
        }

        public void push()
        {
            throw new NotImplementedException();
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
