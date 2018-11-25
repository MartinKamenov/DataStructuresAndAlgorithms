using System.Collections.Generic;

namespace DSA_CSharp.src.Graph_Structures
{
    public class BinaryTree
    {
        public List<BinaryTreeNode> tree;
        private int size;
        
        public BinaryTreeNode root
        {
            get
            {
                return tree[0];
            }
        }

        public BinaryTree()
        {
            this.tree = new List<BinaryTreeNode>();
            this.size = 0;
        }

        public void AddNode(BinaryTreeNode node)
        {
            int index = size - 1;
            if (size == 0)
            {
                node.parent = null;
            }
            else
            {
                node.parent = this.tree[index / 2];
                if (index % 2 == 0)
                {
                    node.parent.leftChild = node;
                }
                else
                {
                    node.parent.rightChild = node;
                }
            }

            this.tree.Add(node);
            this.size++;
        }
    }
}
