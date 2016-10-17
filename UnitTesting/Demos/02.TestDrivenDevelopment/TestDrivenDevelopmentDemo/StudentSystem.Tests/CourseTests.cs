using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Tests
{
    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void AddStudentToCourse_ShouldAddStudentToCourseSuccessfully_IfStudentIsNotNull()
        {
            School school = new School();
            Student student = new Student();
            Course course = new Course();
            
            school.AddStudentToCourse(student, course);

            Assert.AreEqual(1, school.GetStudentsCountForCourse(course).Count());
        }

        [TestMethod]
        [DataRow(-3)]
        [DataRow(-5)]
        [DataRow(-4)]
        public void Age_ShouldNotAcceptNegativeValues(int age)
        {
            Student student = new Student();

            Action ActToTest = () => student.Age = age;

             var ex =  Assert.ThrowsException<ArgumentException>(ActToTest);
        }
    }
}
