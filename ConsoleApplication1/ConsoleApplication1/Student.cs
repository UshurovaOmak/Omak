using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Student
    {
        public string Name;
        public string Surname;

        public Student(string _name, string _surname)
        {
            this.Name = _name;
            this.Surname = _surname;
        }

        public override string ToString()
        {
            return "This student name is " + Name + " " + Surname;
        }
    }
}
