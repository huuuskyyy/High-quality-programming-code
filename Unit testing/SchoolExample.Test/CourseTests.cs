using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SchoolExample.Test
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Course was allowed to set course with more than max students")]
        public void CheckIfProperExceptionIsThrownWhenAddMoreThanMaxStudentsToCourse()
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 35; i++)
            {
                students.Add(new Student("pesho"));
            }
            Course course = new Course("math");

            course.Students = students;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Course name was allowed to be set to null after course creation")]
        public void CheckIfProperExceptionIsThrownWhenSetCourseNameToNullAfterCourseCreation()
        {
            Course course = new Course("math");
            course.Name = null;
        }

        [TestMethod]
        public void CheckIfCourseNameIsChangedAfterCourseCreation()
        {
            Course course = new Course("math");
            course.Name = "financial math";

            Assert.AreEqual("financial math", course.Name, string.Format("Expected output after course name change financial math. Received {0}", course.Name));
        }

        [TestMethod]
        public void CheckIfCourseNameIsSetCorrectlyOnCourseCreation()
        {
            Course course = new Course("math");

            Assert.AreEqual("math", course.Name, string.Format("Expected output for course name on course creation math. Received {0}", course.Name));
        }

        [TestMethod]
        public void CheckIfCourseSetCorrectStudentsListWhenCreated()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student ( "gosho" ));
            Course course = new Course("math", students);

            Assert.AreEqual(students, course.Students, string.Format("Expected to receive list with only one student \'gosho\'. Received list with student name {0}", students[0].Name));
        }

        [TestMethod]
        public void CheckIfCourseNameIsCorrectlySetOnCourseCreation()
        {
            Course course = new Course("math");

            Assert.AreEqual("math", course.Name, string.Format("Expected output for course name on course creation math. Received {0}", course.Name));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "Course name was allowed to be set to null on course creation")]
        public void CheckIfProperExceptionIsThrownWhenSetCourseNameToNullOnCourseCreation()
        {
            Course course = new Course(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Course was allowed to contain more students than max allowed students")]

        public void CheckIfProperExceptionIsThrownWhenMoreStudentsThanMaxAllowedAreAdded()
        {
            Course course = new Course("math");

            for (int i = 0; i < 35; i++)
            {
                course.AddStudent(new Student("pesho"));
            }

        }

        [TestMethod]
        public void CheckIfStudentsAreRemovedFromTheCourse()
        {
            List<Student> students = new List<Student>();
            Student studentOne = new Student("pesho");
            Student studentTwo = new Student("gosho");

            Course course = new Course("math");
            course.AddStudent(studentOne);
            course.AddStudent(studentTwo);

            course.RemoveStudent(studentOne);

            Assert.AreEqual(1, course.Students.Count, string.Format("Expected number of students in the course 1.Received number of students in the course {0}", course.Students.Count));
        }
    }
}
