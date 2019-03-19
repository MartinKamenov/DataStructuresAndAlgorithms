using DSA_CSharp.src.Linked_Lists;
using System;

namespace DSA_CSharp
{
    public class Program
    {
        public static void Main()
        {
            SinglyLinkedList<int> singleLinkedList = new SinglyLinkedList<int>();

            for (int i = 0; i < 5; i++)
            {
                singleLinkedList.AddNode(new SingleLinkedListNode<int>(i));
            }

            singleLinkedList.AddNode(new SingleLinkedListNode<int>(101), 2);
            singleLinkedList.AddNode(new SingleLinkedListNode<int>(102), 200);
            singleLinkedList.AddNode(new SingleLinkedListNode<int>(100), 2);
            singleLinkedList.AddNode(new SingleLinkedListNode<int>(103), 500);

            Console.WriteLine(singleLinkedList.RemoveElementByKey(4));
            Console.WriteLine(singleLinkedList.RemoveElementByKey(2));
            Console.WriteLine(singleLinkedList.RemoveElementByKey(0));
            Console.WriteLine(singleLinkedList.RemoveElementByKey(1));
            Console.WriteLine(singleLinkedList.RemoveElementByKey(404));
            Console.WriteLine(singleLinkedList.RemoveElementByKey(3));

            // Expected: 100, 101, 102, 103
            singleLinkedList.ShowNodes();
        }
    }
}
