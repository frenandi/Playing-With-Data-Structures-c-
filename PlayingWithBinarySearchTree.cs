using DataStructures.Structures;
using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class PlayingWithBinarySearchTree
    {
        public void AddNode(BinaryTree binaryTree, int value)
        {
            BinaryTreeNode before = null;
            BinaryTreeNode after = binaryTree.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
                else
                    return;
            }

            BinaryTreeNode NewBinaryTreeNode = new BinaryTreeNode
            {
                Data = value
            };

            if (binaryTree.Root == null)
                binaryTree.Root = NewBinaryTreeNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = NewBinaryTreeNode;
                else
                    before.RightNode = NewBinaryTreeNode;
            }
        }

        public void AddNodeNotSearch(BinaryTree binaryTree, int value)
        {
            BinaryTreeNode NewBinaryTreeNode = new BinaryTreeNode
            {
                Data = value
            };
            BinaryTreeNode root = binaryTree.Root;
            if (binaryTree.Root == null)
            {
                binaryTree.Root = NewBinaryTreeNode;
                return;
            }
            AddNodeNotSearchRec(binaryTree.Root,NewBinaryTreeNode);
        }

        public void AddNodeNotSearchRec(BinaryTreeNode binaryTreeRoot, BinaryTreeNode NewBinaryTreeNode)
        {
            if(NewBinaryTreeNode.Data < binaryTreeRoot.Data)
            {
                if (binaryTreeRoot.LeftNode == null)
                    binaryTreeRoot.LeftNode = NewBinaryTreeNode;
                else
                    AddNodeNotSearchRec(binaryTreeRoot.LeftNode, NewBinaryTreeNode);
            }
            else
            {
                if (binaryTreeRoot.RightNode == null)
                    binaryTreeRoot.RightNode = NewBinaryTreeNode;
                else
                    AddNodeNotSearchRec(binaryTreeRoot.RightNode, NewBinaryTreeNode);
            }
        }

        public void PrintTraversePreOrder(BinaryTreeNode parent)
        {
            if(parent != null)
            {
                Console.Write(parent.Data);
                PrintTraversePreOrder(parent.LeftNode);
                PrintTraversePreOrder(parent.RightNode);
            }
        }

        public void PrintTraverseInOrder(BinaryTreeNode parent)
        {
            if (parent != null)
            {
                PrintTraverseInOrder(parent.LeftNode);
                Console.Write(parent.Data);
                PrintTraverseInOrder(parent.RightNode);
            }
        }

        public void PrintTraversePostOrder(BinaryTreeNode parent)
        {
            if (parent != null)
            {
                PrintTraversePostOrder(parent.LeftNode);
                PrintTraversePostOrder(parent.RightNode);
                Console.Write(parent.Data);
            }
        }

        public BinaryTreeNode Find(BinaryTree binaryTree,int value)
        {

            return Find(binaryTree, value, binaryTree.Root);
        }

        private BinaryTreeNode Find(BinaryTree binaryTree, int value, BinaryTreeNode parent)
        {
            if (parent != null)
            {
                if (value == parent.Data) return parent;
                if (value < parent.Data)
                    return Find(binaryTree, value, parent.LeftNode);
                else
                    return Find(binaryTree, value, parent.RightNode);
            }

            return null;
        }

        public int GetTreeDepth(BinaryTree binaryTree)
        {
            return GetTreeDepth(binaryTree.Root);
        }

        private int GetTreeDepth(BinaryTreeNode parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
        }

        public void PrintLevel(BinaryTreeNode root, int level)
        {
            if (root == null)
                return;
            if (level == 1)
                Console.WriteLine(root.Data);
            else if (level > 1)
            {
                PrintLevel(root.LeftNode, level - 1);
                PrintLevel(root.RightNode, level - 1);
            }
        }

        public void PrintLevelOrder(BinaryTreeNode binaryTreeRoot)
        {
            if (binaryTreeRoot == null)
                return;

            Queue<BinaryTreeNode> nodeQueue = new Queue<BinaryTreeNode>();
            nodeQueue.Enqueue(binaryTreeRoot);

            while (true)
            {
                int numberOfNodes = nodeQueue.Count;
                if (numberOfNodes == 0) break;

                while(numberOfNodes > 0)
                {
                    BinaryTreeNode currentParentNode = nodeQueue.Peek();
                    Console.Write($"{currentParentNode.Data} ");
                    nodeQueue.Dequeue();
                    if (currentParentNode.LeftNode != null)
                        nodeQueue.Enqueue(currentParentNode.LeftNode);
                    if (currentParentNode.RightNode != null)
                        nodeQueue.Enqueue(currentParentNode.RightNode);
                    numberOfNodes--;
                }

                Console.WriteLine("");
            }
        }
    }
}
