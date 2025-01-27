﻿
namespace Phase1Section4._7b
{
    class SingleLinkedList
    {
        public Node Root { get; private set; }
       
        public int Length { get; private set; }

        public Node Current { get; private set; }

        public Node Next
        { 
            get { return Current.Next; }
        }

        public void Add(Node node)
        {
            if (Root == null)
            {
                Root = node;
                Length = 1;
                Current = node;
            }
            else
            {
                Current.Next = node;
                Current = node;
                Length++;
            }
        }

    }
}
