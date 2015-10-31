using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructures.Trees;
namespace Data_StructureTest
{
    /// <summary>
    /// Summary description for BinaryTreeTest
    /// </summary>
    [TestClass]
    public class BinaryTreeTest
    {
        

        [TestMethod]
        public void testTreeCreation(){
            BinaryTree<int> tree = new BinaryTree<int>();
            Assert.IsNotNull(tree);
            Assert.IsNull(tree.Root);
        }
        [TestMethod]
        public void testInsertTree(){
            BinaryTree<int> tree = new BinaryTree<int>();
            
            tree.insert(5);
            tree.insert(3);
            tree.insert(6);
            Assert.AreEqual(tree.Root.Data, 5);
            Assert.AreEqual(tree.Root.LeftChild.Data,3);
            Assert.AreEqual(tree.Root.RightChild.Data, 6);
        }
        [TestMethod]
        public void testDeleteTree(){
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.insert(5);
            tree.insert(3);
            tree.insert(6);
            tree.insert(2);
            tree.insert(1);
            tree.insert(7);
            tree.insert(8);
            Assert.AreEqual(tree.Root.Data, 5);
            Assert.AreEqual(tree.Root.LeftChild.Data, 3);
            Assert.AreEqual(tree.Root.RightChild.Data, 6);

            tree.delete(3);
            Assert.AreEqual(tree.Root.LeftChild.Data, 2);
        }
    }
}
