using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    public class Person
    {
        private int age;
        
        //Valideringarna du gjorde ska implementeras i dess respektive properties

        public int Age 
        {
            get 
            {
                return age;
            } 
            set
            {
                if(value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be a value > 0");
                }
            }
                
        }
        private string fName;

        public int setage(int age)
        {
            return age;
        }

        public string FName 
        {
            get
            {
                return fName;
            }
            set
            {
                if(value.Length >= 2 && value.Length <= 10)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("First name must be between 2 and 10 characters long");
                }
            }
        }

       

        private string lName;
        public string LName {
            get
            {
                return lName;
            }
            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException("First name must be between 2 and 10 characters long");
                }
            }
        }

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

            //if (age<0)
            //{
            //    throw new ArgumentException("The age must be greater then 0");
            //}
            //if (fName.Split().Length<2 || fName.Split().Length >10)
            //{
            //    throw new ArgumentException("The first name must have more than 2 letters and less than 10");
            //}
            //if (lName.Split().Length < 3 || lName.Split().Length > 15)
            //{
            //    throw new ArgumentException("The last name must have more than 3 letters and less than 15");
            //}
        }

        public Person()
        {
        }

        //Överskuggning av ToString för att skriva ut personens egenskaper
        public override string ToString()
        {
            return $"{Age} {FName} {LName} {Height} {Weight}";
        }
    }
}
