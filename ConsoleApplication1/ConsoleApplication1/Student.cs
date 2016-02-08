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
        public int age;
        public Student(string _name, string _surname, int age)
        {
            this.Name = _name;
            this.Surname = _surname;
            this.age = age;
        }

        public override string ToString()
        {
            return "This student name is " + Name + " " + Surname+ " "+age ;
        }
    }
}
