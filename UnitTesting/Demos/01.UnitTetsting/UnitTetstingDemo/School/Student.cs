namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be nuul,empty or white space!");
                }
                this.name = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (10000 > value || value > 99999)
                {
                    throw new ArgumentException("Id out of range!");
                }
                id = value;
            }
        }

    }
}
