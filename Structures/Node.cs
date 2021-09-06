using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Structures
{
    public class Node
    {
        public Node next;

        public int data;

        public Node(int number)
        {
            data = number;
            next = null;
        }
    }
}
