using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Trees
{
    public class Node<T> where T:IComparable<T>
    {
        T Data;
        Node<T> leftChild;
        Node<T> rightChild;
    }
}
