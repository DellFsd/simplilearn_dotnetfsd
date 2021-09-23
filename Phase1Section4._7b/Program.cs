using System;
using System.Collections.Generic;

namespace Phase1Section4._7b
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunApp();
            string[] words =
           { "the", "fox", "jumps", "over", "the", "dog" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            Display(sentence, "The linked list values:");
            Console.WriteLine("sentence.Contains(\"jump\") = {0}",
           sentence.Contains("jump"));

            // Add the word 'today' to the beginning of the linked list.
            sentence.AddLast("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list:");

        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void RunApp()
        {
            DoubleLinkedList list = new DoubleLinkedList();
            Node n = new Node("root");
            list.Add(n);
            for (int i = 0; i < 10; i++)
            {
                Node node = new Node(i.ToString());
                list.Add(node);
            }

            Console.WriteLine("Length of double linked list=" + list.Length);
            Node nodeRef = list.MoveRoot();
            Console.WriteLine("Traversing forward..");
            while (nodeRef != null)
            {
                Console.WriteLine(nodeRef.Data);
                nodeRef = list.MoveNext();
            }

            Console.WriteLine("Traversing backwards..");
            nodeRef = list.MovePrevious();
            while (nodeRef != null)
            {
                Console.WriteLine(nodeRef.Data);
                nodeRef = list.MovePrevious();
            }

        }

        //public static void RunApp()
        //{
        //    SingleLinkedList list = new SingleLinkedList();
        //    Node n = new Node();
        //    n.Data = "root";
        //    list.Add(n);

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Node node = new Node();
        //        node.Data = i.ToString();
        //        list.Add(node);
        //    }

        //    Console.WriteLine("Length of singly linked list=" + list.Length);
        //    Node nodeRef = list.Root;
        //    while (nodeRef != null)
        //    {
        //        Console.WriteLine(nodeRef.Data);
        //        nodeRef = nodeRef.Next;
        //    }
        //}
    }
}
