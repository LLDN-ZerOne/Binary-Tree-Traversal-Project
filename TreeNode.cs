using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Traversal_Project
{
    internal class TreeNode
    {
        TreeNode rChild;
        TreeNode lChild;
        string data = "";
        public TreeNode(string data,TreeNode lChild = null, TreeNode rChild=null)
        {
            this.rChild = rChild;
            this.lChild = lChild;
            this.data = data;
        }

        public TreeNode Rchild()
        {
            return rChild;
        }
        public TreeNode Lchild()
        {
            return lChild; 
        }
        public string Data()
        {
                        return data;
        }
    }
}
