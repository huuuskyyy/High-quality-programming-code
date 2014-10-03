using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    public class Course
    {
        private List<Student> students;
        private string name;

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                if (value.Count > 30)
                {
                    throw new ArgumentException("Course can have maximum 30 students");
                }
                this.students = value;
            }
        }

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
                    throw new ArgumentNullException("Course name cannot be empty!");
                }
                this.name = value;
            }
        }

        public Course(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Course name cannot be empty!");
            }
            this.name = name;
            students = new List<Student>();
        }

        public Course(string name, List<Student> students)
            
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Course name cannot be empty!");
            }
            this.name = name;
            this.students = students;
        }

        public void AddStudent(Student student)
        {
            if (this.students.Count < 29)
            {
                this.students.Add(student);
            }
            else
            {
                throw new ArgumentException("Course can have maximum 30 students. Limit for this course is reached");
            }
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }
    }
}
