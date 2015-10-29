using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public class Graph<T>
    {
        private Dictionary<T, LinkedList<T>> adjacencyList;
        public Dictionary<T, LinkedList<T>> AdjacencyList { get { return adjacencyList; } }
        private bool directed;
        public bool Directed { get { return directed; } }
        public int numVertices;
        public Graph():this(false){
        }
        public Graph(bool dir){
            directed = dir;
            adjacencyList = new Dictionary<T, LinkedList<T>>();
        }
        public void addVertex(T value){
            if (!adjacencyList.ContainsKey(value)) {
                adjacencyList.Add(value,new LinkedList<T>());
            }
            numVertices++;
        }
        public void addEdge(T valueTo, T valueFrom){
            if (!adjacencyList.ContainsKey(valueTo)){
                adjacencyList[valueTo] = new LinkedList<T>();
                numVertices++;
            }
            if (!adjacencyList.ContainsKey(valueFrom)){
                adjacencyList[valueFrom] = new LinkedList<T>();
                numVertices++;
            }
            adjacencyList[valueFrom].AddLast(valueTo);
            if (!directed){
                adjacencyList[valueTo].AddLast(valueFrom);
            }
        }
        public void deleteEdge(T valueFrom, T valueTo){
            if (adjacencyList[valueFrom].Contains(valueTo)){
                if (!directed){
                    adjacencyList[valueTo].Remove(valueFrom);
                }
                adjacencyList[valueFrom].Remove(valueTo);
            }
        }
        public void deleteVertex(T vertex){
            foreach (T key in adjacencyList.Keys)
            {
                deleteEdge(key, vertex);
            }
            adjacencyList.Remove(vertex);
            numVertices--;
        }
    }
}