using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Tree
{
    /// <summary>
    /// 二叉树定义
    /// </summary>
    public class BinaryTree
    {
        private TreeNode _head; //头指针
        private string cStr; //用于构造二叉树的字符串

        public TreeNode Head //头指针
        {
            get { return _head; }
        }

        //构造方法
        public BinaryTree(string constructStr)
        {
            cStr = constructStr;
            _head = new TreeNode(cStr[0]); //添加头结点
            Insert(_head, 0); //给头结点添加孩子结点
        }

        private void Insert(TreeNode parent, int index)
        {
            int leftIndex = 2 * index + 1; //计算左孩子索引
            if (leftIndex < cStr.Length) //如果索引没超过字符串长度
            {
                if (cStr[leftIndex] != '#') //'#'表示空结点
                {   //添加左孩子
                    parent.Left = new TreeNode(cStr[leftIndex]);
                    //递归调用Add方法给左孩子添加孩子节点
                    Insert(parent.Left, leftIndex);
                }
            }

            int rightIndex = 2 * index + 2;
            if (rightIndex < cStr.Length)
            {
                if (cStr[rightIndex] != '#')
                {   //添加右孩子
                    parent.Right = new TreeNode(cStr[rightIndex]);
                    //递归调用Add方法给右孩子添加孩子节点
                    Insert(parent.Right, rightIndex);
                }
            }
        }

        /// <summary>
        /// 先序遍历
        /// </summary>
        /// <param name="node"></param>
        public void PreOrder(TreeNode node) 
        {
            if (node != null)
            {
                Console.Write(node.ToString()); //打印字符
                PreOrder(node.Left); //递归
                PreOrder(node.Right); //递归
            }
        }

        /// <summary>
        /// 中序遍历
        /// </summary>
        /// <param name="node"></param>
        public void MidOrder(TreeNode node) 
        {
            if (node != null)
            {
                MidOrder(node.Left); //递归
                Console.Write(node.ToString()); //打印字符
                MidOrder(node.Right); //递归
            }
        }

        /// <summary>
        /// 后序遍历
        /// </summary>
        /// <param name="node"></param>
        public void AfterOrder(TreeNode node) 
        {
            if (node != null)
            {
                AfterOrder(node.Left); //递归
                AfterOrder(node.Right); //递归
                Console.Write(node.ToString()); //打印字符
            }
        }

        /// <summary>
        /// 寻找最大值节点
        /// </summary>
        public void FindMax()
        {
            TreeNode current = _head;

            //找到最右边的节点即可
            while (current.Right != null)
            {
                current = current.Right;
            }

            Console.WriteLine("\n最大节点为:" + current.Data);
        }

        /// <summary>
        /// 寻找最小值节点
        /// </summary>
        public void FindMin()
        {
            TreeNode current = _head;

            //找到最左边的节点即可
            while (current.Left != null)
            {
                current = current.Left;
            }

            Console.WriteLine("\n最小节点为:" + current.Data);
        }
    }
}
