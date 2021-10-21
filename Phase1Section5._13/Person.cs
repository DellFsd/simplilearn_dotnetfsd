using System;

namespace Phase1Section5._13
{
    class Person : IComparable<Person>
    {
        public string Name { get; init; }
        public string Address { get; set; }
        public virtual string GetInfo()
        {
            return "Name: " + Name + ", Address= " + Address;
        }

        int IComparable<Person>.CompareTo(Person perB)
        {
            return Name.CompareTo(perB.Name);
        }
    }
}
