using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SchoolExample.Test
{
    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void TestIfSchoolNameIfSetCorrectlyOnCourseCreation()
        {
            School school = new School("8-mo osnovno");
            Assert.AreEqual("8-mo osnovno", school.Name, string.Format("Expected school name on school creation 8-mo osnovno. Received {0}", school.Name));
        }

        [TestMethod]
        public void TestIfSchoolNameIfSetCorrectlyAfterCourseCreation()
        {
            School school = new School("8-mo osnovno");
            school.Name = "PMG osnovno";

            Assert.AreEqual("PMG osnovno", school.Name, string.Format("Expected school name on school creation PMG osnovno. Received {0}", school.Name));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "School name was allowed to be null or empty on school creation")]
        public void TestIfProperExceptionIsThrownWhenSchooleNameIsNullOnSchoolCreation()
        {
            School school = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            "School name was allowed to be null or empty when changed after school creation")]
        public void TestIfProperExceptionIsThrownWhenSchooleNameIsSetNullAfterSchoolCreation()
        {
            School school = new School("8-mo osnovno");
            school.Name = null;
        }

        [TestMethod]
        public void TestIfSchoolAddCorrectListOfCoursesAfterSchoolCreation()
        {
            Course course = new Course("math");
            School school = new School("8-mo osnovno");
            school.AddCourse(course);

            Assert.AreEqual(course, school.Courses[0], string.Format("Expeted to receive course name math. Received {0}", course.Name));
        }

        [TestMethod]
        public void TestIfSchoolAddCorrectListOfCoursesOnSchoolCreation()
        {
            List<Course> courses = new List<Course>( ){new Course("math")};
            School school = new School("8-mo osnovno", courses);

            Assert.AreEqual(courses, school.Courses, string.Format("Expeted to receive first name of courses name math. Received {0}", courses[0].Name));
        }

        [TestMethod]
        public void TestIfSchoolRemoveCorrectCourseFromItsCourses()
        {
            Course math = new Course("math");
            Course chem = new Course("chemistry");

            List<Course> courses = new List<Course>();
            courses.Add(math);
            courses.Add(chem);

            School school = new School("8-mo osnovno", courses);
            school.RemoveCourse(chem);

            Assert.AreEqual(1, school.Courses.Count, string.Format("Expeted to receive one course in school. Received {0}", school.Courses.Count));
        }

        [TestMethod]
        public void TestIfContainsCorrectCoursesListAddedAfterSchoolCreation()
        {
            Course math = new Course("math");
            Course chem = new Course("chemistry");

            List<Course> courses = new List<Course>();
            courses.Add(math);
            courses.Add(chem);

            School school = new School("8-mo osnovno");
            school.Courses = courses;

            Assert.AreEqual(courses, school.Courses, string.Format("Course didn't add correct list with courses after school creation"));
        }
    }
}
