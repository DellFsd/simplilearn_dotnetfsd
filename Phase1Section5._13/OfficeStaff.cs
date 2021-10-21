using System;

namespace Phase1Section5._13
{
    class OfficeStaff : Employee
    {
        public string Position  { get; set; }
        public override string GetInfo()
        {
            return "Name: " + Name + ", Address= " + Address + ", Hire Date = " + HireDate.ToShortDateString() + ", Postition = " + Position;
        }

        public string GetTypeOfPerson()
        {
            return "OfficeStaff";
        }

    }
}
