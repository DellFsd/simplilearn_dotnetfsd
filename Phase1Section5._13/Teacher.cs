using System;
using System.Collections.Generic;

namespace Phase1Section5._13
{
    class Teacher : Employee
    {
        public List<string> ClassList { get; set; }

        public override string GetInfo()
        {
            return "Name: " + Name + ", Address= " + Address + ", Class List = (" + string.Join(", ", ClassList) + ")";
        }

        public void AddClass(string className)
        {
            ClassList.Add(className);
        }

        public void RemoveClass(string className)
        {
            ClassList.Remove(className);
        }
    }
}
