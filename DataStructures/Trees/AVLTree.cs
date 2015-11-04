using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class AVLTree<T> :BinaryTree<T> where T:IComparable<T>
    {
        public AVLTree()
            : base(){

        }
        public void Insert(T value){
            Root =Insert(Root,value);
            Root = BalanceNode(Root);
        }
        public TreeNode<T> Insert(TreeNode<T> node, T value){
           TreeNode<T> InsertedNode= base.Insert(node, value);
           InsertedNode=BalanceNode(InsertedNode);
           return InsertedNode;
        }
        private TreeNode<T> BalanceNode(TreeNode<T> node){
            int balance = getHeight(node.LeftChild) - getHeight(node.RightChild);
            if (balance > 1){
                if (getHeight(node.LeftChild) > 0){
                    node = RotateLeftLeft(node);
                }
                else{
                    node = RotateLeftRight(node);
                }
            }
            else if (balance < -1){
                if (getHeight(node.RightChild) > 0){
                    node = RotateRightLeft(node);
                }
                else{
                    node = RotateRightRight(node);
                }
            }
            return node;
        }
        private TreeNode<T> RotateLeftLeft(TreeNode<T> node){
            node.LeftChild.RightChild = node;
            node.LeftChild = null;
            return node;
        }
        private TreeNode<T> RotateLeftRight(TreeNode<T> node){
            TreeNode<T> newTop = node.LeftChild.RightChild;
            newTop.RightChild = node;
            newTop.LeftChild = node.LeftChild;
            newTop.RightChild.LeftChild = null;
            newTop.RightChild.RightChild = null;
            return newTop;
        }
        private TreeNode<T> RotateRightRight(TreeNode<T> node){
            TreeNode<T> retNode = node.RightChild;
            retNode.LeftChild=node;
            retNode.LeftChild.setRightChild(null);
            return retNode;
        }
        private TreeNode<T> RotateRightLeft(TreeNode<T> node){
            TreeNode<T> newTop = node.RightChild.LeftChild;
            newTop.LeftChild = node;
            newTop.RightChild = node.RightChild;
            newTop.LeftChild.RightChild = null;
            newTop.LeftChild.LeftChild = null;
            return newTop;
        }
        private int getHeight(TreeNode<T> node){
            int height =0;
            if(node!=null){
                int left = getHeight(node.LeftChild);
                int right = getHeight(node.RightChild);
                int maxH = Math.Max(left, right);
               height= maxH++;
            }
            return height;
        }
    }
}
