using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Sharp
{
    public class Node
    {
        public Node(char data)
        {
            Data = data;
        }
        public char Data { get; set; }
        public Node Next { get; set; }
    }
}
