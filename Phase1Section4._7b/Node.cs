﻿
namespace Phase1Section4._7b
{
    class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }


        public Node() { }
        public Node(string data)
        {
            Data = data;
        }

    }
}
