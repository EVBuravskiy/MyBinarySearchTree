namespace MyBinarySearchTree.Models
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private TreeNode<T> Root;
        public int Count;

        public BinarySearchTree()
        {
            Root = null;
            Count = 0;
        }

        public void Add(T item)
        {
            TreeNode<T> newNode = new TreeNode<T>(item);
            if (Root == null)
            {
                Root = newNode;
                Count++;
                return;
            }
            Add(Root, newNode);

        }
        private void Add(TreeNode<T> currentNode, TreeNode<T> newNode)
        {
            if (currentNode.Data.CompareTo(newNode.Data) > 0)
            {
                if (currentNode.LeftNode == null)
                {
                    currentNode.LeftNode = newNode;
                    newNode.ParentNode = currentNode;
                    Count++;
                    return;
                }
                Add(currentNode.LeftNode, newNode);
            }
            else
            {
                if (currentNode.RightNode == null)
                {
                    currentNode.RightNode = newNode;
                    newNode.ParentNode = currentNode;
                    Count++;
                    return;
                }
                Add(currentNode.RightNode, newNode);
            }
        }

        public TreeNode<T> GetNode(T item)
        {
            if (Root == null)
                return null;
            TreeNode<T> current = Root;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return current;
                }
                if (current.Data.CompareTo(item) > 0)
                {
                    current = current.LeftNode;
                }
                else
                {
                    current = current.RightNode;
                }
            }
            return null;
        }

        public bool Instance(T item)
        {
            TreeNode<T> current = GetNode(item);
            if (current != null) return true;
            else return false;
        }

        public List<T> PreOrder()
        {
            List<T> elements = new List<T>();
            if (Root == null)
            {
                return elements;
            }
            PreOrder(Root, elements);
            return elements;
        }

        private void PreOrder(TreeNode<T> currentNode, List<T> elements)
        {
            elements.Add(currentNode.Data);
            if (currentNode.LeftNode != null)
            {
                PreOrder(currentNode.LeftNode, elements);
            }
            if (currentNode.RightNode != null)
            {
                PreOrder(currentNode.RightNode, elements);
            }
        }

        public List<T> PastOrder()
        {
            List<T> elements = new List<T>();
            if (Root == null)
            {
                return elements;
            }
            PastOrder(Root, elements);
            return elements;
        }

        private void PastOrder(TreeNode<T> currentNode, List<T> elements)
        {
            if (currentNode.LeftNode != null)
            {
                PastOrder(currentNode.LeftNode, elements);
            }
            if (currentNode.RightNode != null)
            {
                PastOrder(currentNode.RightNode, elements);
            }
            elements.Add(currentNode.Data);
        }

        public List<T> InOrder()
        {
            List<T> elements = new List<T>();
            if (Root == null)
            {
                return elements;
            }
            InOrder(Root, elements);
            return elements;
        }

        private void InOrder(TreeNode<T> currentNode, List<T> elements)
        {
            if (currentNode.LeftNode != null)
            {
                InOrder(currentNode.LeftNode, elements);
            }
            elements.Add(currentNode.Data);
            if (currentNode.RightNode != null)
            {
                InOrder(currentNode.RightNode, elements);
            }
        }

        public void Remove(T item)
        {
            if (Root == null)
            {
                return;
            }
            List<T> elements = new List<T>();
            TreeNode<T> current = Root;

            if (current.Data.Equals(item))
            {
                elements = PreOrder();
                elements.Remove(item);
                Root = null;
            }
            else
            {
                current = GetNode(item);
                PreOrder(current, elements);
                elements.Remove(item);
                current = current.ParentNode;
                if (current.LeftNode != null && current.LeftNode.Data.Equals(item))
                {
                    current.LeftNode = null;
                }
                if (current.RightNode != null && current.RightNode.Data.Equals(item))
                {
                    current.RightNode = null;
                }
            }
            foreach (var element in elements)
            {
                Add(element);
            }
        }
    }
}
