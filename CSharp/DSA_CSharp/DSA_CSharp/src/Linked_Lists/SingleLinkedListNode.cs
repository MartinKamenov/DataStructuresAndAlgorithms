using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.src.Linked_Lists
{
    public class SingleLinkedListNode<T>
    {
        public T value;
        public SingleLinkedListNode<T> next;

        public SingleLinkedListNode(T value)
        {
            this.value = value;
        }
    }
}
