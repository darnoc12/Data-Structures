using System;
using DataStructures.Graph;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data_StructureTest
{
    /// <summary>
    /// Summary description for WeightedGraphTest
    /// </summary>
    [TestClass]
    public class WeightedGraphTest
    {
        [TestMethod]
        public void testCreation()
        {
            WeightedGraph<int> graph = new WeightedGraph<int>();
            Assert.AreNotEqual(graph, null);
            Assert.IsFalse(graph.Directed);
        }
        [TestMethod]
        public void testAddVertex()
        {
            Graph<int> graph = new Graph<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;

            graph.addVertex(num1);
            graph.addVertex(num2);
            graph.addVertex(num3);
            graph.addVertex(num4);
            graph.addVertex(num5);

            Assert.IsTrue(graph.numVertices == 5);
            Assert.IsTrue(graph.AdjacencyList.ContainsKey(num1));
            Assert.IsTrue(graph.AdjacencyList.ContainsKey(num2));
            Assert.IsTrue(graph.AdjacencyList.ContainsKey(num3));
            Assert.IsTrue(graph.AdjacencyList.ContainsKey(num4));
            Assert.IsTrue(graph.AdjacencyList.ContainsKey(num5));
        }
        [TestMethod]
        public void testAddEdge()
        {
            WeightedGraph<int> graph = new WeightedGraph<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;

            graph.addEdge(num1, num2);
            graph.addEdge(num2, num3);
            graph.addEdge(num3, num4);
            graph.addEdge(num4, num5);
            graph.addEdge(num1, num3);

            Assert.IsTrue(graph.numVertices == 5);
            Assert.IsTrue(graph.AdjacencyList.ContainsKey(num1));
            Assert.IsTrue(graph.AdjacencyList.ContainsKey(num2));
            Assert.IsTrue(graph.AdjacencyList.ContainsKey(num3));
            Assert.IsTrue(graph.AdjacencyList.ContainsKey(num4));
            Assert.IsTrue(graph.AdjacencyList.ContainsKey(num5));

            Assert.IsNotNull(graph.AdjacencyList[num1]);
            Assert.IsNotNull(graph.AdjacencyList[num2]);
            Assert.IsNotNull(graph.AdjacencyList[num3]);
            Assert.IsNotNull(graph.AdjacencyList[num4]);
            Assert.IsNotNull(graph.AdjacencyList[num5]);

            Assert.IsTrue(graph.AdjacencyList[num1].Count == 2);
            Assert.IsTrue(graph.AdjacencyList[num2].Count == 2);
            Assert.IsTrue(graph.AdjacencyList[num3].Count == 3);
            Assert.IsTrue(graph.AdjacencyList[num4].Count == 2);
            Assert.IsTrue(graph.AdjacencyList[num5].Count == 1);
        }
        [TestMethod]
        public void testRemoveEdge()
        {
            WeightedGraph<int> graph = new WeightedGraph<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;

            graph.addEdge(num1, num2);
            graph.addEdge(num2, num3);
            graph.addEdge(num3, num4);
            graph.addEdge(num4, num5);
            graph.addEdge(num1, num3);

            graph.deleteEdge(num1, num2);
            graph.deleteEdge(num1, num3);

            Assert.IsTrue(graph.AdjacencyList[num1].Count == 0);
            Assert.IsTrue(graph.AdjacencyList[num2].Count == 1);
            Assert.IsTrue(graph.AdjacencyList[num3].Count == 2);
            Assert.IsTrue(graph.AdjacencyList[num4].Count == 2);
            Assert.IsTrue(graph.AdjacencyList[num5].Count == 1);
        }
        [TestMethod]
        public void testRemoveVertex()
        {
            WeightedGraph<int> graph = new WeightedGraph<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;

            graph.addEdge(num1, num2);
            graph.addEdge(num2, num3);
            graph.addEdge(num3, num4);
            graph.addEdge(num4, num5);
            graph.addEdge(num1, num3);
            GraphNode<int> node = new GraphNode<int>(num1);

            graph.deleteVertex(num1);
            graph.deleteVertex(num4);
            Assert.IsFalse(graph.AdjacencyList.ContainsKey(num1));
            Assert.IsFalse(graph.AdjacencyList.ContainsKey(num4));
            Assert.IsTrue(graph.numVertices == 3);
            Assert.IsFalse(graph.AdjacencyList[num2].Contains(node));
        }
    }
}
