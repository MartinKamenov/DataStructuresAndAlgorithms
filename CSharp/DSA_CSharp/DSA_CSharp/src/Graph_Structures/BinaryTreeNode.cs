namespace DSA_CSharp.src.Graph_Structures
{
    public class BinaryTreeNode
    {
        public BinaryTreeNode parent;
        public BinaryTreeNode leftChild;
        public BinaryTreeNode rightChild;
        private string text;

        public BinaryTreeNode(string text)
        {
            this.text = text;
        }

        public override string ToString()
        {
            return this.text;
        }
    }
}
