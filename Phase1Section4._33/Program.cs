using System;

namespace Phase1Section4._33
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        public static void RunApp()
        {
            int[] marks = new int[10];
            marks[0] = 80;
            marks[1] = 90;
            marks[2] = 93;
            marks[3] = 76;
            marks[4] = 77;
            marks[5] = 92;
            marks[6] = 89;
            marks[7] = 78;
            marks[8] = 69;
            marks[9] = 56;

            QuickSort(marks, 0, marks.Length - 1);

            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

    }
}
