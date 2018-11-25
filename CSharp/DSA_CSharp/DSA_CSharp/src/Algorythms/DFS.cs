using DSA_CSharp.src.Graph_Structures;
using System;

namespace DSA_CSharp.src.Algorythms
{
    public class DFS
    {
        public static void showNodeDFS(BinaryTreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node);

            showNodeDFS(node.leftChild);
            showNodeDFS(node.rightChild);
        }
    }
}
