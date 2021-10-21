using System;

namespace Phase1Section5._12
{
    class Student : IPerson
    {
        public string Name { get; init; } 
        public string Address { get; set; }
        public DateTime EnrollDate { get; init; }
        public string GetInfo()
        {
            return "Name: " + Name + ", Address= " + Address + ", EnrollDate = " + EnrollDate.ToShortDateString();
        }

        public string GetTypeOfPerson()
        {
            return "Student";
        }
    }
}
