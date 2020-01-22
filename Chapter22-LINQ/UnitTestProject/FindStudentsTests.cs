using Microsoft.VisualStudio.TestTools.UnitTesting;
using Student;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student.Tests
{
    [TestClass()]
    public class FindStudentsTests
    {
        [TestMethod()]
        public void GetStudentsWithFirstNameBeforeLastNameInAlphabeticallyTest()
        {
            //Arrange
            var students = new List<Student>() { new Student("Abby", "Martin", 16), new Student("Barack", "Obama", 26), new Student("Zaria", "Toby", 17) };
            var expectedResult = new List<Student>() { new Student("Abby", "Martin", 16), new Student("Barack", "Obama", 26) };
            //Act
            var actualResult = FindStudents.GetStudentsWithFirstNameBeforeLastNameInAlphabetically(students);
            int a = actualResult.Count;
            //Assert            
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}