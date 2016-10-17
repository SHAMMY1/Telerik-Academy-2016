using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {

        public Course(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
        }

        private List<Student> students;

        public List<Student> Students
        {
            get { return students; }
            private set { students = value; }
        }

        public string Name  { get; set; }


        public void AddStudent(Student student)
        {
            if (this.Students.Count == 30)
            {
                throw new ArgumentException("Course cannot have more than 30 students!");
            }
            this.Students.Add(student);
        }

        public bool RemoveStudent(Student student)
        {
           return this.Students.Remove(student);
        }
    }
}
