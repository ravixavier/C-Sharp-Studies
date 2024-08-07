using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    internal class Program
    {
        struct Person
        {
            public string name;
            public int age;
            public int birthmonth;
        }
        static void Main(string[] args)
        {
            string name = "Ravi";
            int age = 28;

            Person person;

            person.name = "Ravi";
            person.age = 28;
            person.birthmonth = 7;

            Console.WriteLine($"{person.name} - {person.age} - {person.birthmonth}");

            Console.ReadLine();
        }
    }
}
