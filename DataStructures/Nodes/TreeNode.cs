using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class TreeNode<T> where T:IComparable<T>
    {
        private T data;
        public T Data { get { return data; } set { data = value; } }
        private TreeNode<T> leftChild;
        public TreeNode<T> LeftChild { get { return leftChild; } set { leftChild = value; } }
        private TreeNode<T> rightChild;
        public TreeNode<T> RightChild { get { return rightChild; } set { rightChild = value; } }
        //For use in a red-black tree
        public TreeNode(T data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
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
