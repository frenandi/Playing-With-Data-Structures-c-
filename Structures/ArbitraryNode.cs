using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Structures
{
    public class ArbitraryNode
    {
        public int Data { get; set; }

        public ArbitraryNode Next { get; set; }

        public ArbitraryNode RandomNode { get; set; }

        public ArbitraryNode(int data)
        {
            Data = data;
            Next = null;
            RandomNode = null;
        }
    }
}
