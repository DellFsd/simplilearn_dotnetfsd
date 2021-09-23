using System;
using System.Collections.Generic;
using System.Text;

namespace Phase1Section4._9
{
    class Node
    {
        public string Data { get; set; }
        public Node Prev { get; set; }
        public Node Next { get; set; }


        public Node() { }
        public Node(string data)
        {
            Data = data;
        }

    }
}
