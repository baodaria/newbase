using System;
using System.Collections.Generic;
using System.Text;

namespace datastructure
{
    class DoubleNode
    {

        public int Value { get; set; }

        public DoubleNode Previous { get; set; }
        public DoubleNode Next { get; set; }
        public DoubleNode(int value)
        {
            Value = value;
            Next = null;
            Previous = null;
        }
    }
}
