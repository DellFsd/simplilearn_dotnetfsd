﻿using System;
using System.Collections.Generic;

namespace Phase1Section4._9
{
    class Program
    {
        static void Main(string[] args)
        {
           RunApp();
            //Example of using Stack built in to .NET Platform
            //StackExample();
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

        public static void StackExample()
        {
            Stack<string> numbers = new Stack<string>();
            numbers.Push("one");
            numbers.Push("two");
            numbers.Push("three");
            numbers.Push("four");
            numbers.Push("five");

            // A stack can be enumerated without disturbing its contents.
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nPopping '{0}'", numbers.Pop());
            Console.WriteLine("Peek at next item to destack: {0}",
                numbers.Peek());
            Console.WriteLine("Popping '{0}'", numbers.Pop());

            // Create a copy of the stack, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.
            Stack<string> stack2 = new Stack<string>(numbers.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string number in stack2)
            {
                Console.WriteLine(number);
            }

            // Create an array twice the size of the stack and copy the
            // elements of the stack, starting at the middle of the
            // array.
            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            // Create a second stack, using the constructor that accepts an
            // IEnumerable(Of T).
            Stack<string> stack3 = new Stack<string>(array2);

            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            foreach (string number in stack3)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nstack2.Contains(\"four\") = {0}",
                stack2.Contains("four"));

            Console.WriteLine("\nstack2.Clear()");
            stack2.Clear();
            Console.WriteLine("\nstack2.Count = {0}", stack2.Count);
        }
    }
}
