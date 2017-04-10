using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Tree
{
    /// <summary>
    /// 二叉树遍历
    /// </summary>
    public class TreeOrder
    {
        /// <summary>
        /// 先序遍历
        /// </summary>
        /// <param name="root"></param>
        public void PreOrder(TreeNode root)
        {

            if (root == null)
                return;

            Console.WriteLine(root.Data + " ");

            PreOrder(root.Left);

            PreOrder(root.Right);
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="root"></param>
        public void InOrder(TreeNode root)
        {

            if (root == null)
                return;

            InOrder(root.Left);

            Console.WriteLine(root.Data + " ");

            InOrder(root.Right);
        }

        /// <summary>
        /// 后序遍历
        /// </summary>
        /// <param name="root"></param>
        public void PostOrder(TreeNode root)
        {

            if (root == null)
                return;

            PostOrder(root.Left);

            PostOrder(root.Right);

            Console.WriteLine(root.Data + " ");
        }
    }
}
