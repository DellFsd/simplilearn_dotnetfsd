using System;

namespace Phase1Section5._12
{
    class OfficeStaff : IPerson
    {
        public string Name { get; init; }
        public string Address { get; set; }
        public DateTime HireDate { get; init; }
        public string GetInfo()
        {
            return "Name: " + Name + ", Address= " + Address + ", Hire Date = " + HireDate.ToShortDateString();
        }

        public string GetTypeOfPerson()
        {
            return "OfficeStaff";
        }

    }
}
