using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase1Section5._6
{
    class CourseList
    {
        public int NumberOfCourses { get { return Courses.Count; } }
        public List<Course> Courses { get; set; }

        public Course this[int i]
        {
            get { return Courses[i]; }
            set { Courses[i] = value; }
        }

    }
}
