using DSA_CSharp.src.Linked_Lists;
using System;

namespace DSA_CSharp
{
    public class Program
    {
        public static void Main()
        {
            SinglyLinkedList<int> singleLinkedList = new SinglyLinkedList<int>();

            for (int i = 0; i < 100; i++)
            {
                singleLinkedList.AddNode(new SingleLinkedListNode<int>(i));
            }

            singleLinkedList.AddNode(new SingleLinkedListNode<int>(100), 3);
            singleLinkedList.AddNode(new SingleLinkedListNode<int>(102), 200);
            singleLinkedList.AddNode(new SingleLinkedListNode<int>(101), 3);
            singleLinkedList.AddNode(new SingleLinkedListNode<int>(103), 500);

            singleLinkedList.ShowNodes();
        }
    }
}
