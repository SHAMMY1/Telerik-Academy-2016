using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public int GroupNumber { get; set; }

        public int[] Marks { get; set; }

        public Student(string firstName, string lastName, string fN, string tel, string email, int groupNumber, int[] marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
        }
    }
}
