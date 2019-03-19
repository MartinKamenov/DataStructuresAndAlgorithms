using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.src.Linked_Lists
{
    public class SingleLinkedListNode<T> where T:IComparable
    {
        public T value;
        public SingleLinkedListNode<T> next;

        public SingleLinkedListNode(T value)
        {
            this.value = value;
        }
    }
}
