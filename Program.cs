using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Traversal_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode node = ImplementTree();
            ShowTraversal(node);
        }

        private static void ShowTraversal(TreeNode node)
        {
            Console.Write("inorder Travel:");
            InOrder(node);
            Console.Write("\npostorder Travel:");
            PostOrder(node);
            Console.Write("\nperoder Travel:");
            PerOrder(node);
            Console.ReadKey();
        }

        private static TreeNode ImplementTree()
        {
            TreeNode node6 = new TreeNode("g");
            TreeNode node7 = new TreeNode("h");
            TreeNode node8 = new TreeNode("i");
            TreeNode node4 = new TreeNode("e", null, node7);
            TreeNode node2 = new TreeNode("c", null, node4);
            TreeNode node5 = new TreeNode("f", node8);
            TreeNode node3 = new TreeNode("d", node5, node6);
            TreeNode node1 = new TreeNode("b", null, node3);
            TreeNode node = new TreeNode("a", node1, node2);
            return node;
        }

        static void InOrder(TreeNode root)
        {
            if (root != null)
            {
                InOrder(root.Lchild());
                Console.Write(root.Data()+",");
                InOrder(root.Rchild());
            }
           
        }
        static void PerOrder(TreeNode root)
        {
            if (root != null)
            {
                Console.Write(root.Data()+",");
                PerOrder(root.Lchild());
                PerOrder(root.Rchild());
            }
        }
        static void PostOrder(TreeNode root)
        {
            if (root != null)
            {
                PostOrder(root.Lchild());
                PostOrder(root.Rchild());
                Console.Write(root.Data() + ",");
            }
        }
    }
}
