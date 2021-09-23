using System;
using System.Collections.Generic;

namespace Phase1Section4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
            //Example of using Queue built in to .NET Platform
            //QueueExample();
        }

        public static void RunApp()
        {
            Queue Q = new Queue();
            int? testDequeue = Q.Dequeue();
            Console.WriteLine(testDequeue.HasValue ? 
                testDequeue.ToString() : "NULL");

            Q.Enqueue(10);
            Q.Enqueue(20);
            Q.Enqueue(30);
            Q.Enqueue(40);
            Q.Enqueue(50);
            Q.Enqueue(60);
            Q.Enqueue(70);
            Q.Enqueue(80);
            Q.Enqueue(90);
            Q.Enqueue(100);

            Console.WriteLine(Q.PrintQueue());

            Console.WriteLine(Q.Dequeue());
            Console.WriteLine(Q.Peek());
            Console.WriteLine(Q.Dequeue());

            Console.WriteLine(Q.PrintQueue());
        }

        public static void QueueExample()
        {
            Queue<string> numbers = new Queue<string>();
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            // A queue can be enumerated without disturbing its contents.
            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nDequeuing '{0}'", numbers.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}",
                numbers.Peek());
            Console.WriteLine("Dequeuing '{0}'", numbers.Dequeue());

            // Create a copy of the queue, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.
            Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

            Console.WriteLine("\nContents of the first copy:");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }

            // Create an array twice the size of the queue and copy the
            // elements of the queue, starting at the middle of the
            // array.
            string[] array2 = new string[numbers.Count * 2];
            numbers.CopyTo(array2, numbers.Count);

            // Create a second queue, using the constructor that accepts an
            // IEnumerable(Of T).
            Queue<string> queueCopy2 = new Queue<string>(array2);

            Console.WriteLine("\nContents of the second copy, with duplicates and nulls:");
            foreach (string number in queueCopy2)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nqueueCopy.Contains(\"four\") = {0}",
                queueCopy.Contains("four"));

            Console.WriteLine("\nqueueCopy.Clear()");
            queueCopy.Clear();
            Console.WriteLine("\nqueueCopy.Count = {0}", queueCopy.Count);
        }
    }
}

