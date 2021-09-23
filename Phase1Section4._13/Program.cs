using System;
using System.Collections.Generic;

namespace Phase1Section4._13
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        public static void RunApp()
        { 
            List<int> marksList = new List<int> { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };
            //int[] marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };
            int searchItem = 0;
            bool success;
            do
            {
                Console.WriteLine("Enter marks to search and press Enter:");
                string input = Console.ReadLine();
                success = int.TryParse(input, out searchItem);
            } while (!success);

            //int counter = 0;
            //bool foundItem = false;
            //foreach(int i in marks)
            //{
            //    if (i == searchItem)
            //    { 
            //        Console.WriteLine(i + " was found at position " + counter);
            //        foundItem = true;
            //        break;
            //    }
            //    counter++;               
            //}

            //if (!foundItem)
            //    Console.WriteLine("Item not found");
            
            int index =  marksList.FindIndex(i => i == searchItem);
            if (index == -1)
                Console.WriteLine("Item not found");
            else
                Console.WriteLine(searchItem + " was found at position " + index);

        }
    }
}
