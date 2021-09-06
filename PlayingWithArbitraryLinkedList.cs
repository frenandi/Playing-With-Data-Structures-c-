using DataStructures.Structures;

namespace DataStructures
{
    public class PlayingWithArbitraryLinkedList
    {
        public void InsertAtFront(ArbitraryLinkedList arbitraryList,int data, int? keyNode)
        {
            var arbitraryNode = FindArbitraryLinkedNodeByKey(arbitraryList,keyNode);
            ArbitraryNode newArbitraryNode = new ArbitraryNode(data)
            {
                Next = arbitraryList.Head,
                RandomNode = arbitraryNode
            };
            arbitraryList.Head = newArbitraryNode;
        }

        public void InsertAtEnd(ArbitraryLinkedList arbitraryList, int data, int? keyNode)
        {
            var arbitraryNode = FindArbitraryLinkedNodeByKey(arbitraryList, keyNode);
            ArbitraryNode newArbitraryNode = new ArbitraryNode(data)
            {
                RandomNode = arbitraryNode
            };
            if(arbitraryList.Head == null)
            {
                arbitraryList.Head = arbitraryNode;
                return;
            }
            ArbitraryNode lastNode = GetLastNode(arbitraryList);
            lastNode.Next = newArbitraryNode;
        }

        public ArbitraryNode GetLastNode(ArbitraryLinkedList linkedList)
        {
            ArbitraryNode temp = linkedList.Head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            return temp;
        }

        public ArbitraryNode FindArbitraryLinkedNodeByKey(ArbitraryLinkedList arbitraryLinkedList,int? keyNode)
        {
            if (keyNode == null) return null;
            ArbitraryNode temp = arbitraryLinkedList.Head;
            if(temp != null && temp.Data == keyNode)
            {
                return arbitraryLinkedList.Head;
            }
            while(temp != null && temp.Data != keyNode)
            {
                temp = temp.Next;
            }
            if (temp == null)
                return null;
            else
                return temp;
        }

        //public ArbitraryLinkedList CopyArbitraryLinkedList(ArbitraryLinkedList arbitraryLinkedList)
        //{
        //    var copiedArbitraryLinkedList = new ArbitraryLinkedList();
        //    if (arbitraryLinkedList.Head == null) return copiedArbitraryLinkedList;
        //    else copiedArbitraryLinkedList.Head = new ArbitraryNode(arbitraryLinkedList.Head.Data)
        //    {
        //        Next = arbitraryLinkedList.Head.Next,
        //        RandomNode = arbitraryLinkedList.Head.RandomNode
        //    };


        //    ArbitraryNode originalTemp = arbitraryLinkedList.Head.Next;
        //    ArbitraryNode copyNode;
        //    while (originalTemp.Next != null)
        //    {
        //        int dataCopy = originalTemp.Data;
        //        ArbitraryNode copyNext = originalTemp.Next;
        //        ArbitraryNode copyRandomNode = originalTemp.RandomNode;

        //        originalTemp = originalTemp.Next;
        //    }
        //    return temp;
        //}
    }
}
