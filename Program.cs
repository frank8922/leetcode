using System;
using Trees;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TreeNode root = new TreeNode(1, null, null);
            TreeNode left = new TreeNode(5);
            TreeNode right = new TreeNode(3);
            root.left = left;
            root.right = right;
            Console.WriteLine(root.left.val);
        }
    }
}
