using DSA_CSharp.Linear_Structures.List;
using DSA_CSharp.src.Algorythms;
using DSA_CSharp.src.Graph_Structures;
using DSA_CSharp.src.Linear_Structures.Stack;
using DSA_CSharp.src.Sorting;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*BinaryTree tree = new BinaryTree();
            for (int i = 0; i < 10; i++)
            {
                tree.AddNode(new BinaryTreeNode("Node " + i));
            }

            DFS.showNodeDFS(tree.root);*/

            int[] array = new int[] { 10, 15, 6, 3, 12, 8, 1, 100, 50, 18, 0, 15, 35, 14, 12 };
            Console.WriteLine(string.Join(" ", CountingSort.CountingSortFunction(array, 100)));
        }
    }
}
