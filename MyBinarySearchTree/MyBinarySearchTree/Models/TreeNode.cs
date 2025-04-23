namespace MyBinarySearchTree.Models
{
    public class TreeNode<T> : IComparable<T> where T : IComparable<T>
    {
        public TreeNode<T> ParentNode { get; set; }
        public T Data { get; set; }

        public TreeNode<T> LeftNode { get; set; }

        public TreeNode<T> RightNode { get; set; }

        public TreeNode()
        {
            ParentNode = LeftNode = RightNode = null;
            Data = default(T);
        }

        public TreeNode(T data) : this()
        {
            Data = data;
        }

        public int CompareTo(T? other)
        {
            return Data.CompareTo(other);
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
