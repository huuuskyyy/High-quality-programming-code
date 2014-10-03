using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolExample
{
    public class Student
    {

        private string name;
        private int number;

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
                    throw new ArgumentNullException("Student name cannot be empty!");
                }
                this.name = value;
            }
        }

        public int Number
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }

        public Student(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Student name cannot be empty!");
            }
            this.name = name;
            this.number = Generator.GenerateUniqueNumber();
        }

    }
}
