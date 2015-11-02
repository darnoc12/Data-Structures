using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class BinaryTree<T> where T :IComparable<T>
    {
        private int numNodes;
        public int NumNodes { get { return numNodes; } }
        /*  The root node of the binary tree*/
        private TreeNode<T> root;
        public TreeNode<T> Root { get { return root; } set { root = value; } }
        public BinaryTree(){
            root = null;
            numNodes = 0;
        }
        /* insert a value into the tree */
        public void insert(T value){
            TreeNode<T> node = new TreeNode<T>(value);
            if(root==null)
            {
                root = node;
            }
            else
            {
                if (root.Data.CompareTo(value) > 0)
                {
                 root.LeftChild =insert(root.LeftChild, value);
                }
                else
                {
                   root.RightChild= insert(root.RightChild, value);
                }
            }
        }
        private TreeNode<T> insert(TreeNode<T> node, T value){
            if (node == null)
            {
                node = new TreeNode<T>(value);
                return node;
                numNodes++;
            }
            else
            {
                if (node.Data.CompareTo(value) > 0)
                {
                    node.LeftChild=insert(node.LeftChild, value);
                    return node;
                }
                else
                {
                    node.RightChild=insert(node.RightChild, value);
                    return node;
                }
            }
        }
        public void delete(T value){
               root =delete(root,value);
            }
           private TreeNode<T> delete(TreeNode<T> node, T value){
                if (node == null)
                {
                    return null;
                }
                else if (node.Data.CompareTo(value) == 0)
                {
                    if (!node.LeftChildExists() && !node.RightChildExists())
                    {
                        return null;
                    }
                    else if (node.LeftChildExists() && !node.RightChildExists())
                    {
                        node = node.LeftChild;
                        return node;
                    }
                    else if (!node.LeftChildExists()&& node.RightChildExists())
                    {
                        node = node = node.RightChild;
                        return node;
                    }
                    else
                    {
                        node= inOrderSuccessor(node);
                        node.RightChild=delete(node.RightChild, node.Data);
                        return node;
                    }
                }//Node not the correct node to delete continue to search
                else{
                    if (node.Data.CompareTo(value) > 0){
                        node.LeftChild = delete(node.LeftChild, value);
                        return node;
                    }
                    else{
                        node.RightChild = delete(node.RightChild, value);
                        return node;
                    }
                }
               }
           public TreeNode<T> search(T value){
               return search(root, value);
           }
           private TreeNode<T> search(TreeNode<T> node, T value){
               if(node.Data.CompareTo(value)==0)
               {
                   return node;
               }
               else { 
                  if(node == null)
                  {
                      return null;
                  }
                  else{
                      if(node.Data.CompareTo(value)>0)
                      {
                          return search(node.LeftChild, value);
                      }
                      else
                          return search(node.RightChild,value);
                  }
               }
           }
            private TreeNode<T> inOrderSuccessor(TreeNode<T> node){
                if(!node.RightChildExists()){
                    return node;
                }
                else{
                    node = node.RightChild;
                    while(node.LeftChildExists()){
                        node=node.LeftChild;
                    }
                    TreeNode<T> returnNode = node;
                    node = null;
                    return returnNode;
                }
            }
     }
}