using System;
using System.Collections.Generic;
using System.Linq;

namespace Phase1Section5._13
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        public static void RunApp()
        {

            Teacher teacher = new Teacher()
            {
                Name = "Mr. Teacher",
                Address = "some address",
                HireDate = DateTime.Today,
                ClassList = new List<string> { "Spanish 1", "Spanish 2", "Conversational Spanish" }
            };

            Student student = new Student()
            {
                Name = "Student name",
                Address = "some address",
                DOB = DateTime.Today
            };

            OfficeStaff staff = new OfficeStaff()
            {
                Name = "Mr. Staff",
                Address = "some address",
                HireDate = DateTime.Today,
                Position = "Guidence Counselor"
            };


            Console.WriteLine(teacher.GetInfo() + "\n" + teacher.GetType().Name);
            Console.WriteLine(student.GetInfo() + "\n" + student.GetType().Name);
            Console.WriteLine(staff.GetInfo() + "\n" + staff.GetType().Name);


            //IComparable examples
            Teacher teacher2 = new Teacher()
            {
                Name = "Mr. Teacher",
                Address = "some address",
                HireDate = DateTime.Today.AddDays(-2),
                ClassList = new List<string> { "Italian 1", "Italian 2", "Conversational Italian" }
            };

            List<Teacher> teachers = new List<Teacher> { teacher, teacher2 };
            List<Person> teachersAsPersons = teachers.Cast<Person>().ToList();
            teachers.Sort();
            teachersAsPersons.Sort();

        }
    }

}
