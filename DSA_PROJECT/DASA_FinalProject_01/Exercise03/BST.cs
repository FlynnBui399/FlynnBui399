using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DASA_FinalProject_01
{
    internal class BST
    {   
        private TreeNode root;
        public TreeNode foundNode = null;
        public class TreeNode
        {  
            public int Value;
            public TreeNode Left, Right;
            public TreeNode(int value)
            {
                Value = value;
                Left = Right = null;
            }
        }

        public BST()
        {
            root = null;
        }
        public void Insert(int value)
        {
            root = InsertRecursive(root, value);
        }

        private TreeNode InsertRecursive(TreeNode root, int value)
        {
            if (root == null)
            {
                root = new TreeNode(value);
                return root;
            }

            if (value < root.Value)
                root.Left = InsertRecursive(root.Left, value);
            else if (value > root.Value)
                root.Right = InsertRecursive(root.Right, value);

            return root;
        }
        
        public bool Search(int value)
        {
            return SearchRecursive(root, value);
        }

        private bool SearchRecursive(TreeNode root, int value)
        {
            if (root == null)
                return false;

            if (value == root.Value)
                return true;

            if (value < root.Value)
                return SearchRecursive(root.Left, value);
            else
                return SearchRecursive(root.Right, value);
        }
    
        public void InOrderTraversal(Action<int> action)
        {
            InOrderTraversalRecursive(root, action);
        }

        private void InOrderTraversalRecursive(TreeNode root, Action<int> action)
        {
            if (root != null)
            {
                 InOrderTraversalRecursive(root.Left, action);
                 action(root.Value);
                 InOrderTraversalRecursive(root.Right, action);
            }
        }
        public void Delete(int value)
        {
            root = DeleteRecursive(root, value);
        }
        private TreeNode DeleteRecursive(TreeNode root, int value)
        {
            if (root == null)
                return root;

            if (value < root.Value)
                root.Left = DeleteRecursive(root.Left, value);
            else if (value > root.Value)
                root.Right = DeleteRecursive(root.Right, value);
            else
            {
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;

                root.Value = MinValue(root.Right);
                root.Right = DeleteRecursive(root.Right, root.Value);
            }
            return root;
        }

        private int MinValue(TreeNode root)
        {
            int minValue = root.Value;
            while (root.Left != null)
            {
                minValue = root.Left.Value;
                root = root.Left;
            }
            return minValue;
        }
        public TreeNode GetRoot()
        {
            return root;
        }
        public int CountNodes(TreeNode node)
        {
            if (node == null)
                return 0;
            return 1 + CountNodes(node.Left) + CountNodes(node.Right);
        }
        public int CountLeafNodes(TreeNode node)
        {
            if (node == null)
                return 0;
            if (node.Left == null && node.Right == null)
                return 1;
            return CountLeafNodes(node.Left) + CountLeafNodes(node.Right);
        }
        public int CountOneChildNodes(TreeNode node)
        {
            if (node == null)
                return 0;
            int count = 0;
            if ((node.Left != null && node.Right == null) || (node.Left == null && node.Right != null))
                count = 1;
            return count + CountOneChildNodes(node.Left) + CountOneChildNodes(node.Right);
        }
        public int CountTwoChildNodes(TreeNode node)
        {
            if (node == null)
                return 0;
            int count = 0;
            if (node.Left != null && node.Right != null)
                count = 1;
            return count + CountTwoChildNodes(node.Left) + CountTwoChildNodes(node.Right);
        }
        public int GetDepth(TreeNode node)
        {
            if (node == null)
                return 0;
            int leftDepth = GetDepth(node.Left);
            int rightDepth = GetDepth(node.Right);
            return Math.Max(leftDepth, rightDepth) + 1;
        }
        public TreeNode SearchingNode(int value)
        {
            return SearchingNodeRecursive(root, value);
        }

        private TreeNode SearchingNodeRecursive(TreeNode node, int value)
        {
            if (node == null)
                return null;

            if (node.Value == value)
                return node; // Trả về node tìm thấy

            // Tìm kiếm đệ quy
            if (value < node.Value)
                return SearchingNodeRecursive(node.Left, value);
            else
                return SearchingNodeRecursive(node.Right, value);
        }
        public void Clear()
        {
            root = null; 
        }
    }
}
