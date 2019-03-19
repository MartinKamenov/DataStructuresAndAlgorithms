using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.src.Linked_Lists
{
    public class SinglyLinkedList<T>
    {
        public SingleLinkedListNode<T> head;

        public SinglyLinkedList()
        {
            this.head = null;
        }

        public void AddNode(SingleLinkedListNode<T> node)
        {
            if (this.head == null)
            {
                this.head = node;
                return;
            }

            SingleLinkedListNode<T> last = this.head;

            while (last.next != null)
            {
                last = last.next;
            }

            last.next = node;
            return;
        }

        public void AddNode(SingleLinkedListNode<T> node, int position)
        {
            if (position < 0)
            {
                throw new ArgumentException("Position should be positive number");
            }

            if (this.head == null)
            {
                this.head = node;
                return;
            }

            SingleLinkedListNode<T> last = this.head.next;

            int counter = 1;

            while (last.next != null && counter != position)
            {
                last = last.next;
                counter++;
            }

            if (last.next != null)
            {
                node.next = last.next;
            }

            last.next = node;

            return;
        }

        public void ShowNodes()
        {
            SingleLinkedListNode<T> node = this.head;

            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }
        }
    }
}
