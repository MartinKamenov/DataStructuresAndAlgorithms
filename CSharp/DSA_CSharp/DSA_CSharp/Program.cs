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

            Stack<int> stack = new Stack<int>();
            stack.Add(1);
            stack.Add(2);
            stack.Add(3);
            stack.Add(4);
            stack.Add(5);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Add(6);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
