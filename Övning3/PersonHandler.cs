using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;


namespace Övning3
{
    class PersonHandler
    {
       

        public void SetAge(Person pers, int age)
        {
            //Kan göras direkt tilldelning till dess property
            pers.Age = age;
        }

        //public string GetPersonInfo(Person person)
        //{
        //    return person();
        //}

        

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            //var person = new Person();
            //person.setage(age);
            //person.setfName(fName);
            //person.setlName(lName);
            //person.setheight(height);
            //person.setweight(weight);

            //Här kan du också tilldela direkt till respektive Person properties.

            var person = new Person()
            {
                Age = age,
                FName = fName,
                LName = lName,
                Height = height,
                Weight = weight
            };

            return person;
        }
        
    }
}
