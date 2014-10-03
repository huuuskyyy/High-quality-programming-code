using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SchoolExample.Test
{
    [TestClass]
    public class UnitTest1
    {
        //must be placed first since it test the value of the very first student created
        [TestMethod]
        public void TestIfStudentNumberIsSetCorrectlyOnFirstCreatedStudent()
        {
            Student studentOne = new Student("pesho");

            Assert.AreEqual(10001, studentOne.Number, string.Format("Expected output 10001. Received {0}", studentOne.Number));
        }

        [TestMethod]
        public void TestCorrectSetOfStudentNameWhenCreatingStudent()
        {
            Student student = new Student("gosho");
            Assert.AreEqual("gosho", student.Name, string.Format("Expected student name gosho. Received student name {0}", student.Name));
        }

        [TestMethod]
        public void TestCorrectSetOfStudentNameWhenChangingStudentName()
        {
            Student student = new Student("pesho");
            student.Name = "gosho";
            Assert.AreEqual("gosho", student.Name, string.Format("Expected student name {0}", student.Name), string.Format("Expected student name gosho. Received student name {0}", student.Name));
        }

        [TestMethod]
        public void TestIfStudentNumberIsSetIncreasingOrderWhenCreateStuden()
        {
            Student studentOne = new Student("pesho");
            Student studentTwo = new Student("gosho");
            int numberDifference = studentTwo.Number - studentOne.Number;

            Assert.AreEqual(1, numberDifference, string.Format("Expected output 1. Received {0}", numberDifference));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            ("Student name was allowed to be set to null, when student created"))]
        public void TestIfArgumentNullExceptionIsThrownWhenSetStudentNameToNullOnCreate()
        {
            string name = null;
            Student studentOne = new Student(name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException),
            ("Student name was allowed to be set to null, when name set later"))]
        public void TestIfArgumentNullExceptionIsThrownWhenSetStudentNameToNullAfterStudentCreate()
        {
            string name = null;
            Student studentOne = new Student("gosho");
            studentOne.Name = name;
        }
    }
}
