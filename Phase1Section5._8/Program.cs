using System;
using System.Collections.Generic;

namespace Phase1Section5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApp();
        }

        public static void RunApp()
        {
            Subject algebra = new Subject("Algebra");

            Subject physics = new Subject("Physics");

            SubjectTeacher algebraTeacher = new SubjectTeacher("Mr. Algebra", "Some Address", Convert.ToDateTime("2009-10-20 00:00:00"), algebra);
            //algebraTeacher.Name = "Mr.Algebra";
            //algebraTeacher.ContactAddress = "Some Address";
            //algebraTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            //algebraTeacher.WhichSubject = algebra;

            SubjectTeacher physicsTeacher = new SubjectTeacher("Mr. Physics", "Some Address", Convert.ToDateTime("2009-10-20 00:00:00"), physics);

            Teacher teacherOf8 = new Teacher("Mrs. Class 8 Teacher", "Some Address", Convert.ToDateTime("2009-10-20 00:00:00"));
            SubjectTeacher teacherOf8Sub = new SubjectTeacher(teacherOf8, physics);
            List<SubjectTeacher> physicsTeachers = new List<SubjectTeacher> { physicsTeacher, teacherOf8Sub };

            Course class8 = new Course("8", physicsTeachers);

            CourseTeacher teacherOf8Course = new CourseTeacher(teacherOf8, class8);

            class8.SwitchTeacher(teacherOf8Course);

            CourseTeacher algebraTeacherCourse = new CourseTeacher(algebraTeacher, class8);

            class8.SwitchTeacher(algebraTeacherCourse);
        }
    }
}
