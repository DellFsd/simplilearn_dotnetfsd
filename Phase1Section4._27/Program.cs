using System;

namespace Phase1Section4._27
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();

            //More real world example
            //FactorialRecursion(5);
        }

        public static void RunApp()
        {
            string[] students = new string[10];
            students[0] = "Karuna";
            students[1] = "Mark";
            students[2] = "Advaith";
            students[3] = "Sangeeta";
            students[4] = "Nazia";
            students[5] = "Faisal";
            students[6] = "Tania";
            students[7] = "Guru";
            students[8] = "Chandni";
            students[9] = "Kamleshwar";

            int currElem = 0;
            PrintViaRecursion(students, currElem);
        }

        public static void PrintViaRecursion(string[] arr, int currElem)
        {
            Console.WriteLine(arr[currElem]);
            if (currElem < arr.Length - 1)
                PrintViaRecursion(arr, currElem + 1);
        }

        public static double FactorialRecursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * FactorialRecursion(number - 1);
        }
    }
}
