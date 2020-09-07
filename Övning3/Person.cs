using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    public class Person
    {
        private int age;
        
        public int Age { get;  }
        private string fName;

        public int setage(int age)
        {
            return age;
        }

        public string FName { get; set; }

       

        private string lName;
        public string LName { get; set; }

        private double height;
        public double Height { get; set; }

        private double weight;
        public double Weight { get; set; }

        internal string setlName(string lName)
        {
            return lName;
        }

        internal double setweight(double weight)
        {
            return weight;
        }

        internal double setheight(double height)
        {
            return height;
        }

        internal string setfName(string fName)
        {
            return fName;
        }

     

        public Person(int age, string fName, string lName, double height, double weight)
        {
            
            Age = age;
            FName = fName;
            LName = lName;
            Height = height;
            Weight = weight;
            if (age<0)
            {
                throw new ArgumentException("The age must be greater then 0");
            }
            if (fName.Split().Length<2 || fName.Split().Length >10)
            {
                throw new ArgumentException("The first name must have more than 2 letters and less than 10");
            }
            if (lName.Split().Length < 3 || lName.Split().Length > 15)
            {
                throw new ArgumentException("The last name must have more than 3 letters and less than 15");
            }
        }

        public Person()
        {
        }
    }
}
