using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //blue print
    class Human
    {
        //constructor
        public Human(string firstName, string LastName, string eyeColor, int age)
        {
            FirstName = firstName;
            this.LastName = LastName;
            EyeColor = eyeColor;
            Age = age;
        }

        //member variables
        //public string FirstName;
        //public string LastName;

        //private variable while using constructor
        private string FirstName;
        private string LastName;
        private string EyeColor;
        private int Age;

        //member method
        public void Introduce()
        {
            Console.WriteLine("Hi My name is " + FirstName + ' ' + LastName + " and " + " My eye color is " + EyeColor);
            Console.WriteLine("I am "+ Age + " years old");
        }
    }
}
