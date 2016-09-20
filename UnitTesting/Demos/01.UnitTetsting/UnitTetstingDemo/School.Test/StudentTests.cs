using NUnit.Framework;
using School;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Test
{
    [TestFixture]
    public class StudentTests
    {
        [Test]
        public void Expect_Student_Initialise_Corectly_Name()
        {
            string name = "Pesho";
            int id = 10000;

            var student = new Student(name, id);

            Assert.AreEqual(student.Name, name);
        }

        [Test]
        public void Expect_Student_Initialise_Corectly_Id()
        {
            string name = "Pesho";
            int id = 10203;

            var student = new Student(name, id);

            Assert.AreEqual(student.Id, id);
        }

        [Test]
        public void Expect_Stuednt_To_Throw_Empty_Name()
        {
            string name = null;
            int id = 10203;

            var student = new Student(name, id);
            
        }

        [Test]
        public void Expect_Stuednt_To_Throw_Larger_Id()
        {
            string name = "Pesho";
            int id = 10000203;

            var student = new Student(name, id);


        }

        [Test]
        public void Expect_Stuednt_To_Throw_Smaller_Id()
        {
            string name = "Pesho";
            int id = 100;

            var student = new Student(name, id);


        }
    }
}
