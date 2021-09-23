using System;

namespace Phase1Section4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
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
    }
}

