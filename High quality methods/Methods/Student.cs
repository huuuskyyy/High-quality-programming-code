using System;

namespace Methods
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string otherInfo;
        
        public Student (string firstName, string lastName, string otherInfo)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.otherInfo = otherInfo;
        }

        public Student(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.otherInfo = "";
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                this.otherInfo = value;
            }
        }


        public bool IsOlderThan(Student other)
        {
            DateTime firstDate =
                DateTime.Parse(this.otherInfo.Substring(this.otherInfo.Length - 10));
            DateTime secondDate =
                DateTime.Parse(other.otherInfo.Substring(other.otherInfo.Length - 10));
            return firstDate > secondDate;
        }
    }
}
