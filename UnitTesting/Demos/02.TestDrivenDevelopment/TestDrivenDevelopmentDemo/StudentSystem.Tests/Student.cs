namespace StudentSystem.Tests
{
    using System;

    internal class Student
    {
        private int age;

        public int Age
        {
            get
            {
                return this.age;
            }
            internal set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be less than zero!");
                }

                this.age = value;
            }
        }
    }
}