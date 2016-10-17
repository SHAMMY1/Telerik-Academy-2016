using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Test
{


    [TestClass]
    public class CourseTests
    {

        [TestMethod]
        public void Course_InitialiseCorectly_Name()
        {
            string name = "Psho";

            var course = new Course(name);

            Assert.AreEqual(course.Name, name);
        }

        [TestMethod]
        public void Course_InitialiseCorectly_Students()
        {
            string name = "Psho";

            var course = new Course(name);

            Assert.IsNotNull(course.Students);
        }

        [TestMethod]
        public void AddStudent_AddingCorectStudent_ShoudAddStudent()
        {
            var student = new Student("Pesho", 10001);
            var course = new Course("First");

            course.AddStudent(student);

            Assert.IsTrue(course.Students.Contains(student));
        }

        [TestMethod]
        public void Course_RemoveStudent_RemoveCorectly()
        {
            var student = new Student("Pesho", 10001);
            var course = new Course("First");

            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.IsFalse(course.Students.Contains(student));
        }

        [TestMethod, ExpectedException(typeof(Exception),AllowDerivedTypes = true)]
        public void Course_AddMoreThan30Students_ShoudThrow()
        {
            var course = new Course("First");

            for (int i = 0; i < 40; i++)
            {
                course.AddStudent(new Student("Sudent" + i, 10000 + i));
            }
        }
    }
}
