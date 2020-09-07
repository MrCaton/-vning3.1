using System;
using System.Collections.Generic;

namespace Övning3
{
    class Program
    {
       static void Main(string[] args)
        {
            SeedData();
            var data = new List<SeedData>();
            foreach (var data in SeedData)
            {
                Console.WriteLine(person);
            }
        }
        static Person person = new Person();
        static PersonHandler persons = new PersonHandler();
        //person = persons.CreatePerson(age, fName, lName, height, weight);
        private static void SeedData()
        {
            persons.CreatePerson(26, "Ivan", "Araque", 190, 84.2);
            persons.CreatePerson(35, "James", "Peter", 166, 95);
            persons.CreatePerson(96, "Zlatan", "Ibrahimovic", 196, 75.2);
            persons.CreatePerson(14, "Malin", "Andersson", 158, 66);
            persons.CreatePerson(5, "Stefan", "Smith", 172, 54);
            persons.CreatePerson(99, "Eva", "Flores", 185, 78.8);
            persons.CreatePerson(58, "Mohammed", "Alvic", 167, 102.5);
        }
    }
}
