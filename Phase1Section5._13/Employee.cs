using System;

namespace Phase1Section5._13
{
    class Employee : Person, IComparable<Employee>
    {
        public DateTime HireDate { get; init; }
        public override string GetInfo()
        {
            return "Name: " + Name + ", Address= " + Address + ", Hire Date = " + HireDate.ToShortDateString();
        }

        int IComparable<Employee>.CompareTo(Employee empB)
        {
            if (Name == empB.Name)
                return HireDate.CompareTo(empB.HireDate);
            else
                return Name.CompareTo(empB.Name);
        }
    }
}
