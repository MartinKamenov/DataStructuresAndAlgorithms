using DSA_CSharp.Linear_Structures.List;
using DSA_CSharp.src.Algorythms;
using DSA_CSharp.src.Graph_Structures;
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
            BinaryTree tree = new BinaryTree();
            for (int i = 0; i < 10; i++)
            {
                tree.AddNode(new BinaryTreeNode("Node " + i));
            }

            DFS.showNodeDFS(tree.root);
        }
    }
}
