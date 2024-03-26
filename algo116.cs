using System;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int RangeSumBST(TreeNode root, int low, int high)
        {

            var st = new Stack<TreeNode>();
            var sum = 0;
            st.Push(root);

            while (st.Count > 0)
            {
                var curr = st.Pop();
                if (curr != null)
                {

                    if (curr.val >= low && curr.val <= high)
                    {
                        sum += curr.val;
                    }
                    if (curr.val > low)
                    {
                        st.Push(curr.left);

                    }
                    if (curr.val < high)
                    {
                        st.Push(curr.right);
                    }
                }

            }
            return sum;
        }
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.right = new TreeNode(15);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(7);
            root.right.right = new TreeNode(18);
            int low = 7;
            int high = 15;

            Console.WriteLine(RangeSumBST(root, low, high));
        }
    }


    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val)
        {
            this.val = val;
            this.left = null;
            this.right = null;
        }
    }

}

