namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class School
    {

        public School()
        {
            this.Students = new List<Student>();
            this.Courses = new List<Course>();
        }

        private List<Student> students;

        public List<Student> Students
        {
            get
            {
                return students;
            }
            private set
            {
                students = value;
            }
        }

        private List<Course> courses;

        public List<Course> Courses
        {
            get { return courses; }
            set { courses = value; }
        }


        public void AddStudent(Student student)
        {
            if (this.Students.Any(s => s.Id == student.Id))
            {
                throw new ArgumentException("student id must be uniq!");
            }
            this.Students.Add(student);
        }

    }
}
