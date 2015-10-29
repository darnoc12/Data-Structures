using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Graph
{
    public class WeightedGraph<T>
    {
        private Dictionary<T, LinkedList<GraphNode<T>>> adjacencyList;
        public Dictionary<T, LinkedList<GraphNode<T>>> AdjacencyList { get { return adjacencyList; } }

        private bool directed;
        public bool Directed { get { return directed; } }
        public int numVertices;
        public WeightedGraph()
            : this(false)
        {
        }
        public WeightedGraph(bool dir)
        {
            directed = dir;
            adjacencyList = new Dictionary<T, LinkedList<GraphNode<T>>>();
        }
        public void addVertex(T value)
        {
            if (!adjacencyList.ContainsKey(value))
            {
                adjacencyList.Add(value, new LinkedList<GraphNode<T>>());
            }
            numVertices++;
        }
        public void addEdge(T valueTo, T valueFrom)
        {
            if (!adjacencyList.ContainsKey(valueTo))
            {
                adjacencyList[valueTo] = new LinkedList<GraphNode<T>>();
                numVertices++;
            }
            if (!adjacencyList.ContainsKey(valueFrom))
            {
                adjacencyList[valueFrom] = new LinkedList<GraphNode<T>>();
                numVertices++;
            }
            adjacencyList[valueFrom].AddLast(new GraphNode<T>(valueTo));
            if (!directed)
            {
                adjacencyList[valueTo].AddLast(new GraphNode<T>(valueFrom));
            }
        }
        public void addEdge(T valueFrom,T valueTo,int cost)
        {

        }
        public void deleteEdge(T valueFrom, T valueTo)
        {
            GraphNode<T> node = new GraphNode<T>(valueTo);
            if (adjacencyList[valueFrom].Contains(node))
            {
                if (!directed)
                {
                    adjacencyList[valueTo].Remove(new GraphNode<T>(valueFrom));
                }
                adjacencyList[valueFrom].Remove(node);
            }
        }
        public void deleteVertex(T vertex)
        {
            var keys = adjacencyList.Keys;
            foreach (T key in keys)
            {
                deleteEdge(key, vertex);
            }
            adjacencyList.Remove(vertex);
            numVertices--;
        }
    }
}
public class GraphNode<T>
{
    T Data;
    int cost;
    bool visited;
    public GraphNode(T data)
    {
        Data = data;
        visited = false;
        cost = 1;
    }
    public GraphNode(T data, int weight)
    {
        Data = data;
        cost = weight;
        visited = false;
    }
    public override bool Equals(object obj)
    {
        GraphNode<T> node = (GraphNode<T>)obj;
        return EqualityComparer<T>.Default.Equals(this.Data, node.Data);
    }
}