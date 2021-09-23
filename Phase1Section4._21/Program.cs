using System;
using System.Collections;
using System.Collections.Generic;

namespace Phase1Section4._21
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunApp();
            SortExample();
        }

        public static void RunApp()
        {
            List<int> marksList = new List<int> { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };
            marksList.Sort();
            //int[] marks = new int[10] { 55, 58, 60, 63, 64, 67, 72, 74, 89, 98 };
            int[] marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };
            Array.Sort(marks);
            bool success;
            int searchItem;
            do
            {
                Console.WriteLine("Enter marks to search and press Enter:");
                string input = Console.ReadLine();
                success = int.TryParse(input, out searchItem);
            } while (!success);

            int minIndex = 0;
            int maxIndex = marks.Length - 1;

            int foundIndex = -1;

            while (minIndex <= maxIndex && foundIndex == -1)
            {
                int mid = (minIndex + maxIndex) / 2;
                if (searchItem == marks[mid])
                {
                    foundIndex = mid;
                    break;
                }
                else if (searchItem < marks[mid])
                {
                    maxIndex = mid - 1;
                }
                else
                {
                    minIndex = mid + 1;
                }
            }

            if (foundIndex > -1)
            {
                Console.WriteLine("Found " + searchItem + " at " + foundIndex);
            }
        }

        public static void SortExample()
        {
            int[] marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };
            Array.Sort(marks);
            marks = new int[10] { 56, 90, 76, 88, 82, 67, 98, 83, 67, 79 };
            IComparer myComparer = new myReverserClass();
            Array.Sort(marks, myComparer);
        }

        public class myReverserClass : IComparer
        {

            // Calls CaseInsensitiveComparer.Compare with the parameters reversed.
            int IComparer.Compare(Object x, Object y)
            {
                return ((new CaseInsensitiveComparer()).Compare(y, x));
            }
        }
    }
}

