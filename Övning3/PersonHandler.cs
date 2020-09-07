using System;
using System.Collections.Generic;
using System.Text;


namespace Övning3
{
    class PersonHandler
    {
       

        public void SetAge(Person pers, int age)
        {
            pers.setage(age);
            
        }

        //public string GetPersonInfo(Person person)
        //{
        //    return person();
        //}

        

        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            var person = new Person();
            person.setage(age);
            person.setfName(fName);
            person.setlName(lName);
            person.setheight(height);
            person.setweight(weight);
            return person;
        }
        
    }
}
