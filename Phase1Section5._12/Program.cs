using System;
using System.Collections.Generic;

namespace Phase1Section5._12
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
                HireDate = DateTime.Today
            };

            Student student = new Student()
            {
                Name = "Student name",
                Address = "some address",
                EnrollDate = DateTime.Today
            };

            OfficeStaff staff = new OfficeStaff()
            {
                Name = "Mr. Staff",
                Address = "some address",
                HireDate = DateTime.Today
            };

            List<IPerson> people = new List<IPerson>();
            people.Add(teacher);
            people.Add(student);
            people.Add(staff);

            foreach(IPerson person in people)
                Console.WriteLine(person.GetInfo() + "\n" + person.GetTypeOfPerson());

            Console.WriteLine(teacher.GetInfo() + "\n" + teacher.GetTypeOfPerson());
            Console.WriteLine(student.GetInfo() + "\n" + student.GetTypeOfPerson());
            Console.WriteLine(staff.GetInfo() + "\n" + staff.GetTypeOfPerson());
        }
    }

}
