using MyBinarySearchTree.Models;

namespace MyBinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> myBST = new BinarySearchTree<int>();
            myBST.Add(4);
            myBST.Add(2);
            myBST.Add(6);
            myBST.Add(1);
            myBST.Add(3);
            myBST.Add(5);
            myBST.Add(7);
            myBST.Add(8);

            TreeNode<int> findNode = myBST.GetNode(6);

            Console.WriteLine(myBST.Instance(5));

            List<int> preList = myBST.PreOrder();
            foreach (int i in preList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            List<int> pastList = myBST.PastOrder();

            List<int> inList = myBST.InOrder();

            myBST.Remove(6);
            preList = myBST.PreOrder();
            foreach (int i in preList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            myBST.Remove(8);
            preList = myBST.PreOrder();
            foreach (int i in preList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            myBST.Remove(4);
            preList = myBST.PreOrder();
            foreach (int i in preList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}