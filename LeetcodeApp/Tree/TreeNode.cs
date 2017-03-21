using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Tree
{
    /// <summary>
    /// Definition for a binary tree node.
    /// </summary>
    public class TreeNode
    {
        private object _data; //数据
        private TreeNode _left; //左孩子
        private TreeNode _right; //右孩子

        public object Data
        {
            get { return _data; }
        }

        public TreeNode Left //左孩子
        {
            get { return _left; }
            set { _left = value; }
        }

        public TreeNode Right //右孩子
        {
            get { return _right; }
            set { _right = value; }
        }

        //构造方法
        public TreeNode(object data)
        {
            _data = data;
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }
}
