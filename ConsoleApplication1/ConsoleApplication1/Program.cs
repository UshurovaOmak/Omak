using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string surname = Console.ReadLine();
            string age = Console.ReadLine();

            int convertedAge = Int16.Parse(age);
            //int convertAgeMethod2 = Convert.ToInt16(age);
            //int convertAgeMethod3 = 0;

            //bool isParse = Int32.TryParse(age, out convertAgeMethod3);

            Student s = new Student(name, surname, convertedAge);
            Console.WriteLine(s);

            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
