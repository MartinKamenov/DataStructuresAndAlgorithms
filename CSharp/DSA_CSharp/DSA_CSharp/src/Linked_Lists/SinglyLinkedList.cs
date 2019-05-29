using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.src.Linked_Lists
{
    public class SinglyLinkedList<T> where T:IComparable
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

        public bool RemoveElementByKey(T key)
        {
            if (this.head != null && this.head.value.CompareTo(key) == 0)
            {
                if(this.head.next != null)
                {
                    this.head = this.head.next;
                    return true;
                }

                this.head = null;
                return true;
            }

            SingleLinkedListNode<T> node = this.head;

            while (node.next != null && node.next.value.CompareTo(key) != 0)
            {
                node = node.next;
            }

            if (node.next == null)
            {
                return false;
            }

            if (node.next != null && node.next.next != null)
            {
                node.next = node.next.next;
                return true;
            }

            if (node.next != null && node.next.next == null)
            {
                node.next = node.next.next;
            }

            return true;
        }

        public bool RemoveElementByIndex(int position)
        {
            if (position == 0 && this.head != null && this.head.next != null)
            {
                this.head = this.head.next;
                return true;
            }

            SingleLinkedListNode<T> current = this.head;
            int index = 1;

            while (current != null && index != position)
            {
                current = current.next;
                index++;
            }

            if (current == null)
            {
                return false;
            }

            current.next = current.next.next;

            return true;
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
