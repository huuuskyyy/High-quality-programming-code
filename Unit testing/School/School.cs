using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    public class School
    {
        private string name;
        private List<Course> courses;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("School name cannot be empty!");
                }
                this.name = value;
            }
        }

        public List<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }

        public School(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("School name cannot be empty!");
            }
            this.name = name;
            this.courses = new List<Course>();
        }

        public School(string name, List<Course> courses)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("School name cannot be empty!");
            }
            this.name = name;
            this.courses = courses;
        }

        public void AddCourse(Course course)
        {
            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            this.courses.Remove(course);
        }
    }
}
