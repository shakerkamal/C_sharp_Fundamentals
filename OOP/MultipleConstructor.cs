using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //class with multiple constructors  aka constructor overloading
    class MultipleConstructor
    {
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //default constructor
        public MultipleConstructor()
        {
            Console.WriteLine("Constructor is called, object is created");
        }

        public MultipleConstructor(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        public MultipleConstructor(int age)
        {
            this.age = age;
        }

        public void Introduce()
        {
            Console.WriteLine("Hi My name is " + firstName + ' ' + lastName + " and " + " My eye color is " + eyeColor);
            Console.WriteLine("I am " + age + " years old from MULTIPLE CONSTRUCTOR");
        }
    }
}
