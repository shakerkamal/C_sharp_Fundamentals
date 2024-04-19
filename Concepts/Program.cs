using System;

namespace Concepts
{

    public struct Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Complex a = new Complex() { Real = 3, Imaginary = 5 };
            Complex b = new Complex() { Real = 1, Imaginary = 3 };
            Complex c = a + b;
            //sbyte b = 127;
            Console.WriteLine("Hello World!");
        }

        //Overloadable operators  --------> +, -, /, *, %, &, |, ++, --, true, false, comparison operators(>, <, ==, !=) must be overloaded in pairs  
        public static Complex operator +(Complex a, Complex b){
            return new Complex{
                Real = a.Real + b.Real,
                Imaginary = a.Imaginary + b.Imaginary
            };
        }
        
    }
}


