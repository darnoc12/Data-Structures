using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class Node<T> where T:IComparable<T>
    {
        private T data;
        public T Data { get { return data; } set { data = value; } }
        private Node<T> leftChild;
        public Node<T> LeftChild;
        private Node<T> rightChild;
        public Node<T> RightChild;
        //For use in a red-black tree
        private bool red;
        public bool Red { get { return red; } set { red = value; } }
        private int balance;
        public int Balance { get { return balance; } set { balance = value; } }
        public Node(T data)
        {
            this.data = data;
            leftChild = null;
            rightChild = null;
            red = false;
        }  
    }

}
