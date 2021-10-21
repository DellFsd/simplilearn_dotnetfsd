using System;

namespace Phase1Section5._11
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        public static void RunApp()
        {
            ElementarySchoolGradeCard elementary = new ElementarySchoolGradeCard(90, 78, 80, 67);
            Console.WriteLine("Total marks Elementary = " + elementary.TotalMarks);

            MiddleSchoolGradeCard middle = new MiddleSchoolGradeCard(90, 78, 80, 87, 76);
            Console.WriteLine("Total marks Middle School = " + middle.TotalMarks);

            HighSchoolGradeCard high = new HighSchoolGradeCard(90, 78, 80, 87, 76, 90, 76, 70);
            Console.WriteLine("Total marks High School = " + high.TotalMarks);

            high.Math = 80;
            Console.WriteLine("Updated total marks High School = " + high.TotalMarks);
        }

    }
}
