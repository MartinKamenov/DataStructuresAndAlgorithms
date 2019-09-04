using DSA_CSharp.src.Graph_Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_CSharp.src.Algorythms
{
    public class BFS
    {
        public static void GetChildrenNodes(BinaryTreeNode node)
        {
            ShowNode(node);
            GetChildrenNodesBFS(node);
        }
        public static void GetChildrenNodesBFS(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }

            ShowNode(node.leftChild);
            ShowNode(node.rightChild);

            GetChildrenNodesBFS(node.leftChild);
            GetChildrenNodesBFS(node.rightChild);
        }

        public static void ShowNode(BinaryTreeNode node)
        {
            Console.WriteLine(node);
        }
    }
}
