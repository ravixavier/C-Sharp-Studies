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
            /*string name = "Ravi";
            int age = 28;
            int birthmonth = 7;

            Person person;

            person.name = "Ravi";
            person.age = 28;
            person.birthmonth = 7;

            Console.WriteLine($"{person.name} - {person.age} - {person.birthmonth}");
            Console.WriteLine($"{name} - {age} - {birthmonth}");

            string newName = "";
            int newAge = 0;
            int newBirthmonth = 0;

            ReturnPerson(ref newName, ref newAge, ref newBirthmonth);
            Console.WriteLine($"{newName} - {newAge} - {newBirthmonth}");*/

            //Person person;
            //person = ReturnPerson();
            //aqui eu poderia ter escrito de uma forma mais abreviada, exemplo abaixo

            Person person = ReturnPerson();

            Console.WriteLine($"{person.name} - {person.age} - {person.birthmonth}");

            Console.ReadLine();
        }

        static Person ReturnPerson()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birthmonth: ");
            int birthMonth = Convert.ToInt32(Console.ReadLine());

            Person person;

            person.name = name;
            person.age = age;
            person.birthmonth = birthMonth;

            return person;
        }

        /*static void ReturnPerson(ref string name, ref int age, ref int birthMonth)
        {
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your birthmonth: ");
            birthMonth = Convert.ToInt32(Console.ReadLine());
        }*/

    }
}
