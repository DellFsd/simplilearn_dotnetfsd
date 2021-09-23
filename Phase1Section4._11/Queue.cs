using System;
using System.Collections.Generic;

namespace Phase1Section4._11
{
    public class Queue
    {
        private List<int> elements;

        public Queue()
        {
            elements = new List<int>();
        }

        public void Enqueue(int item)
        {
            elements.Add(item);
        }

        public int? Dequeue()
        {         
            int? ret = Peek();
            if (ret.HasValue)
                elements.RemoveAt(0);
            return ret;
        }

        public int? Peek()
        {
            if (elements.Count == 0)
                return null;

            int ret = elements[0];
            return ret;
        }


        public string PrintQueue()
        {
            string retVal = "";
            if (elements.Count == 0)
            {
                return retVal;
            }
            else
            {
                foreach(int element in elements)
                {
                    retVal += element + " ";
                }
            }
            return retVal;
        }
    }
}

