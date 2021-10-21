using System;
using System.Runtime;

namespace Phase1Section5._13
{
    class Student : Person, IComparable<Student>
    {
        public DateTime DOB { get; init; }
        public override string GetInfo()
        {
            return "Name: " + Name + ", Address= " + Address + ", Date of Birth = " + DOB.ToShortDateString();
        }

        int IComparable<Student>.CompareTo(Student studentB)
        {
            if (Name == studentB.Name)
                return DOB.CompareTo(studentB.DOB);
            else
                return Name.CompareTo(studentB.Name);
        }
    }
}
