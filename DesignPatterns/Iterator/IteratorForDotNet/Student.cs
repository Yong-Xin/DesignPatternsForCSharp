using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator.IteratorForDotNet
{
    public class Student
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public Student(string name, string sex)
        {
            Name = name;
            Sex = sex;
        }

        public Student()
        {

        }
    }
}
