using DataStructures.Structures;
using System;

namespace DataStructures
{
    public class PlayingWithLinkedList
    {
        public void AtFrontInsertIntoSingleList (LinkedList linkedList, int insertValue)
        {
            Node newNode = new Node(insertValue)
            {
                next = linkedList.Head
            };
            linkedList.Head = newNode;
        }

        public void AtLastInsertIntoSingleList(LinkedList linkedList, int insertValue)
        {
            Node newNode = new Node(insertValue);
            if(linkedList.Head == null)
            {
                linkedList.Head = newNode;
                return;
            }
            Node lastNode = GetLastNode(linkedList);
            lastNode.next = newNode;
        }

        public void InsertAfterSpecificNode(Node prevNode, int value)
        {
            Node newNode = new Node(value);
            newNode.next = prevNode.next;
            prevNode.next = newNode;
        }

        public void DeletteNodeByKey(LinkedList linkedList, int value)
        {
            Node temp = linkedList.Head;
            Node prev = null;
            if(temp != null && temp.data == value)
            {
                linkedList.Head = temp.next;
                return;
            }
            while(temp != null && temp.data != value)
            {
                prev = temp;
                temp = temp.next;
            }
            if(temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public void ReverseLinkedList(LinkedList linkedList)
        {
            Node previous = null;
            Node current = linkedList.Head;
            Node temp = null;
            while(current != null)
            {
                temp = current.next; //guarda el nodo siguiente del actual, para que no se pierda la referencia
                current.next = previous; //cambia la referencia del actual al anterior
                previous = current; //guardo el actual como el previo
                current = temp; //jalo la referencia que antes guarde
            }
            linkedList.Head = previous;
        }

        public Node GetLastNode(LinkedList linkedList)
        {
            Node temp = linkedList.Head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void PrintList(LinkedList linkedList)
        {
            if (linkedList.Head == null)
                return;   
            
            Node temp = linkedList.Head;
            
            Console.WriteLine($"La cabezona = {temp.data}");
            while (temp.next != null)
            {                
                temp = temp.next;
                Console.WriteLine(temp.data);
            }
        }
    }
}
