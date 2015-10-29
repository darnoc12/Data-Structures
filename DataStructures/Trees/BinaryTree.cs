using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class BinaryTree<T> where T :IComparable<T>
    {
        private Node<T> root;
        public Node<T> Root { get { return root; } set { root = value; } }
        public BinaryTree(){
            root = null;
        }
        public void insert(T value){
            Node<T> node = new Node<T>(value);
            if(root==null)
            {
                root = node;
            }
            else
            {
                if (root.Data.CompareTo(value) < 0){
                    insert(root.LeftChild, value);
                }
                insert(root.RightChild, value);
            }
        }
        public void insert(Node<T> node, T value){
            if (node == null)
            {
                node = new Node<T>(value);
            }
            else
            {
                if (root.Data.CompareTo(value) < 0)
                {
                    insert(root.LeftChild, value);
                }
                else
                {
                    insert(root.RightChild, value);
                }
            }
        }
            public void delete(T value){

            }
    }
}