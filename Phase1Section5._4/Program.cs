using System;

namespace Phase1Section5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            DoApp();
        }

        public static void DoApp()
        {

            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Name = "Name " + i.ToString();
                students[i].Address = "Address of student ";
                students[i].RollNumber = i;
                students[i].ClassName = " VA";
                students[i].DateOfBirth = Convert.ToDateTime("1992-09-10 00:00:00");
            }

            foreach (Student student in students)
            {
                Console.Write(student.Name + ",");
                Console.Write(student.Address + ",");
                Console.Write(student.RollNumber + ",");
                Console.Write(student.ClassName + ",");
                Console.Write(student.DateOfBirth);
                Console.WriteLine("------------------------");
            }

            Student student1 = new Student
            {
                Name = "Name 200",
                Address = "Address of student ",
                RollNumber = 200,
                ClassName = " VA",
                DateOfBirth = Convert.ToDateTime("1992-09-10 00:00:00")
            };

            Student student2 = student1;
            Console.WriteLine("Student 1 is the same as Student 2:" + student1.Equals(student2));
            Console.WriteLine("Student 1 is a " + student1.GetType().Name);
            student2.Name = "Name 201";
            student2.Address = "A different Address";
            student2.RollNumber = 201;
            Console.WriteLine("Student 1 is the same as Student 2:" + student1.Equals(student2));

        }
    }

    struct Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int RollNumber { get; set; }
        public string ClassName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
