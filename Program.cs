using DataStructures.Structures;
using System;
using System.Collections.Generic;
using System.IO;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //FindMissingNumber();
            //DetermineSumIntegersIsEqualToGivenValue();
            //PlayWithSingleLinkList();
            //Merge2Lists();
            //fibonacci();
            BinaryTree();
            //p1();

        }

        private static void p1()
        {
                //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            ///int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = new List<int>
            {
                6,4,2,3,2,5,1,2
            };

            //for (int i = 0; i < arrCount; i++)
            //{
            //    int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
            //    arr.Add(arrItem);
            //}


            List<int> result = Result.minimalHeaviestSetA(arr);
            List<int> secondResult = Result.MinimalHeaviestSetB(arr);

            Console.WriteLine("test");

                //textWriter.WriteLine(String.Join("\n", result));

                //textWriter.Flush();
                //textWriter.Close();
        }

        private static void FindMissingNumber()
        {
            var FindMissingNumber = new FindMissingNumber();
            int[] intArray = { 1, 2, 3, 5, 6, 7, 8 };
            var result = FindMissingNumber.findMissingNumberInArray(intArray);
            Console.WriteLine($"Missing Value is = {result}");
        }

        private static void DetermineSumIntegersIsEqualToGivenValue()
        {
            var Determine = new DetermineSumIntegersIsEqualToGivenValue();
            int[] intArray = { 1, 2, 3, 5, 6, 7, 8 };
            var result2 = Determine.IsTheSumEqual(intArray, 10);
            Console.WriteLine($"There are Values = {result2}");            
        }

        private static void PlayWithSingleLinkList()
        {
            var playingWithSingleList = new PlayingWithLinkedList();
            var LinkedSingleList = new LinkedList();
            playingWithSingleList.AtLastInsertIntoSingleList(LinkedSingleList, 1);
            playingWithSingleList.AtFrontInsertIntoSingleList(LinkedSingleList, 0);
            playingWithSingleList.AtLastInsertIntoSingleList(LinkedSingleList, 2);
            playingWithSingleList.AtLastInsertIntoSingleList(LinkedSingleList, 3);
            playingWithSingleList.AtLastInsertIntoSingleList(LinkedSingleList, 4);
            playingWithSingleList.PrintList(LinkedSingleList);
            playingWithSingleList.DeletteNodeByKey(LinkedSingleList, 1);
            playingWithSingleList.PrintList(LinkedSingleList);
            playingWithSingleList.ReverseLinkedList(LinkedSingleList);
            playingWithSingleList.PrintList(LinkedSingleList);
        }

        private static void Merge2Lists()
        {
            var playingWithSingleList = new PlayingWithLinkedList();
            var MergeLists = new MergeLists();
            var MergeListsMyWay = new MergeListsMyWay();
            int[] intArray = { 1, 2, 3, 5, 6, 7, 8 };
            int[] intArray2 = { 1, 2, 3, 5, 6, 7, 8 };
            playingWithSingleList.PrintList(MergeLists.MergeLinkedLists(intArray, intArray2));
            playingWithSingleList.PrintList(MergeListsMyWay.MergeLinkedLists(intArray, intArray2));
        }

        private static void fibonacci()
        {
            var normalFibValue = Fibonacci.NormalFibonacci(1);
            Console.WriteLine($"Fibonacci: {normalFibValue}");
            var normalFibReturningOneValue = Fibonacci.NormalFibonnacciReturningFromOnetoTo(7);
            Console.WriteLine($"Fibonacci: {normalFibReturningOneValue}");
            var recursiveFibValue = Fibonacci.RecursiveFibonacci(7);
            Console.WriteLine($"Fibonacci: {recursiveFibValue}");
            var recursiveFibValueMemoized = Fibonacci.RecursiveMemoizedFibonacci(7);
            Console.WriteLine($"Fibonacci: {recursiveFibValueMemoized}");
            var bottomUpFibValue = Fibonacci.BottomUpMemoized(7);
            Console.WriteLine($"Fibonacci: {bottomUpFibValue}");
        }

        private static void BinaryTree()
        {
            var playingWithBinaryTree = new PlayingWithBinarySearchTree();
            var BinarySearchTree = new BinaryTree();
            playingWithBinaryTree.AddNode(BinarySearchTree, 100);
            playingWithBinaryTree.AddNode(BinarySearchTree, 50);
            playingWithBinaryTree.AddNode(BinarySearchTree, 200);
            playingWithBinaryTree.AddNode(BinarySearchTree, 25);
            playingWithBinaryTree.AddNode(BinarySearchTree, 75);
            playingWithBinaryTree.AddNode(BinarySearchTree, 350);
            Console.WriteLine("TranversePreOrder");
            playingWithBinaryTree.PrintTraversePreOrder(BinarySearchTree.Root);
            Console.WriteLine("PrintTraverseInOrder");
            playingWithBinaryTree.PrintTraverseInOrder(BinarySearchTree.Root);
            Console.WriteLine("PrintTraversePostOrder");
            playingWithBinaryTree.PrintTraversePostOrder(BinarySearchTree.Root);
            Console.WriteLine("PrinttreeLEvel");
            playingWithBinaryTree.PrintLevelOrder(BinarySearchTree.Root);
            Console.WriteLine("findValue");
            var value = playingWithBinaryTree.Find(BinarySearchTree, 6);
            if (value != null)
                Console.WriteLine(playingWithBinaryTree.Find(BinarySearchTree, 6).Data);
            else
                Console.WriteLine("Value Not Found");
            Console.WriteLine("Depth");
            Console.WriteLine(playingWithBinaryTree.GetTreeDepth(BinarySearchTree));

            //var BinaryTree = new BinaryTree();
            //playingWithBinaryTree.AddNodeNotSearch(BinaryTree, 100);
            //playingWithBinaryTree.AddNodeNotSearch(BinaryTree, 50);
            //playingWithBinaryTree.AddNodeNotSearch(BinaryTree, 200);
            //playingWithBinaryTree.AddNodeNotSearch(BinaryTree, 25);
            //playingWithBinaryTree.AddNodeNotSearch(BinaryTree, 75);
            //playingWithBinaryTree.AddNodeNotSearch(BinaryTree, 350);
            //Console.WriteLine("TranversePreOrder -- JustBinary");
            //playingWithBinaryTree.PrintTraversePreOrder(BinaryTree.Root);
            //Console.WriteLine("PrintTraverseInOrder -- JustBinary");
            //playingWithBinaryTree.PrintTraverseInOrder(BinaryTree.Root);
            //Console.WriteLine("PrintTraversePostOrder -- JustBinary");
            //playingWithBinaryTree.PrintTraversePostOrder(BinaryTree.Root);
            //Console.WriteLine("findValue -- JustBinary");
            //var valueJustBinary = playingWithBinaryTree.Find(BinaryTree, 6);
            //if (valueJustBinary != null)
            //    Console.WriteLine(playingWithBinaryTree.Find(BinarySearchTree, 6).Data);
            //else
            //    Console.WriteLine("Value Not Found -- JustBinary");
            //Console.WriteLine("Depth -- JustBinary");
            //Console.WriteLine(playingWithBinaryTree.GetTreeDepth(BinaryTree));



        }
    }
}
