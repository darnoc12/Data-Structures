using DataStructures.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class TreeNode<T>:Node<T> where T:IComparable<T>
    {
        private TreeNode<T> leftChild;
        public TreeNode<T> LeftChild { get { return leftChild; } set { leftChild = value; } }
        private TreeNode<T> rightChild;
        public TreeNode<T> RightChild { get { return rightChild; } set { rightChild = value; } }
        public int Balance;
        public TreeNode(T data):base(data)
        {
            leftChild = null;
            rightChild = null;
            Balance = 0;
        }
        public bool RightChildExists(){
            return this.rightChild!=null;
        }
        public bool LeftChildExists(){
            return this.leftChild != null;
        }
        public void setLeftChild(TreeNode<T> node)
        {
            LeftChild = node;
        }
        public void setRightChild(TreeNode<T> node)
        {
            rightChild = node;
        }
    }

}
