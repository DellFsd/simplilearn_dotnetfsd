using System;

namespace Phase1Section4._7b
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        public static void RunApp()
        {
            SingleLinkedList list = new SingleLinkedList();
            Node n = new Node();
            n.Data = "root";
            list.Add(n);

            for (int i = 0; i < 10; i++)
            {
                Node node = new Node();
                node.Data = i.ToString();
                list.Add(node);
            }

            Console.WriteLine("Length of singly linked list=" + list.Length);
            Node nodeRef = list.Root;
            while (nodeRef != null)
            {
                Console.WriteLine(nodeRef.Data);
                nodeRef = nodeRef.Next;
            }
        }
    }
}
