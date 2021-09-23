using System;
using System.Collections.Generic;

namespace Phase1Section4._9
{
    class Program
    {
        static void Main(string[] args)
        {
           RunApp();
        }

        public static void RunApp()
        {
            Stack stack = new Stack();
            Console.WriteLine("length of stack=" + stack.Length);
            if(stack.Peek() == null)
                Console.WriteLine("Stack contains nothing");

            for (int i = 0; i < 10; i++)
            {
                Node n = new Node(i.ToString());
                stack.Push(n);
                Console.WriteLine("length of stack=" + stack.Length);
            }

            Node node = stack.Pop();
            Console.WriteLine("Popped " + node.Data);

            node = stack.Pop();
            Console.WriteLine("Popped " + node.Data);

            node = stack.Peek();
            Console.WriteLine("Peeked " + node.Data);

            Console.WriteLine(stack.ListContents());
        }
    }
}
