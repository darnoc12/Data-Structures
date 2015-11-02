using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Nodes
{
    public class Node<T> where T: IComparable
    {
        private T data;
        public T Data { get { return data; } set { data = value; } }
        Node(T value){
            data = value;
        }
    }
}
