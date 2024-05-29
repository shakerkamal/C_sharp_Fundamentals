using System;

namespace FunctionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Division: ");
            Console.WriteLine(Divide(5,0));
            Console.WriteLine("Addition: ");
            Console.WriteLine(Add(5,6));
            Console.WriteLine("With User Input: ");
            Console.WriteLine(Input());
            Console.ReadKey();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        
        public static double Divide(int a, int b)
        {
            return (double) a / b;
        }

        public static int Input()
        {
            Console.WriteLine("Write a number: ");
            string s1 = Console.ReadLine();
            Console.WriteLine("Write a number: ");
            string s2 = Console.ReadLine();
            ///try-catch block
            //try
            //{
            //    n1 = int.Parse(s1);
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("Expected interger input, invalid input");
            //}
            //finally     // it will always be called after try-catch block
            //{
            //    Console.WriteLine("I am gonna get called everytime try-catch executes");
            //}

            bool res = int.TryParse(s1, out int n1);
            if (!res)
            {
                Console.WriteLine("Invalid input {0}" , s1);
            }

            int n2 = int.Parse(s2);

            return n1 + n2;
        }
    }
}
