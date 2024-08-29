using System;
using System.Collections.Generic;

//to study --->  delegates

namespace LambdaExp
{
    // lambda expression is an anonymous fuction that can be used to create delegates
    // or expression trees types. By using lambda expressions, you can write local functions
    // that can be passed as arguments or returned as the value of function calls. 
    // helpful for writing linq query expressions
    class Program
    {
        //create a delegate
        public delegate int SomeMath(int i);

        public delegate bool Compare(int i, Number n);

        static void Main(string[] args)
        {
            DoSomething();
            Console.ReadKey();
        }

        public static void DoSomething()
        {
            //initialize a delegate
            SomeMath math = new SomeMath(Square);  //==> square method takes 1 param and delegate will call that method
            SomeMath sqr = (n) => Square(n);
            System.Console.WriteLine(math(9));
            System.Console.WriteLine(sqr(5));
            //SomeMath add = new SomeMath(Add);  //==> add method takes 2 params so it will cause into a build error
            //System.Console.WriteLine(add(9));

            //creating delegate inside a method
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<int> evenNumbers = list.FindAll(delegate (int i)
            {
                return (i % 2 == 0);
            });

            foreach (int val in evenNumbers)
            {
                System.Console.WriteLine(val);
            }

            //parameters => expression/statement block

            //with lambda expression
            List<int> odd = list.FindAll(i => i % 2 == 1);
            odd.ForEach(i => System.Console.WriteLine(i));

            math = new SomeMath(x => x * x * x);
            System.Console.WriteLine(math(17));

            Compare cmp = (a, number) => a == number.n;
            System.Console.WriteLine(cmp(1, n: new Number { n = 1 }));

            Number nn = new Number();
            nn.n = 1;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Square(int i)
        {
            return i * i;
        }
        public static int TimesThree(int i)
        {
            return i * 3;
        }
    }

    public class Number
    {
        public int n { get; set; }
    }
}
