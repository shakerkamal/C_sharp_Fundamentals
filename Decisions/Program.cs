using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter temp: ");
            string temperature = Console.ReadLine();

            //if (int.TryParse(temperature, out int temp))
            //{
            //    if (temp < 20)
            //    {
            //        Console.WriteLine("A little bit cold");
            //    }
            //    if (temp > 20)
            //    {
            //        Console.WriteLine("Starting to feel hot");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong input");
            //}

            if(int.TryParse(temperature, out int temp))
            {
                switch (temp)
                {
                    case 20:
                        Console.WriteLine("avg temperature");
                        break;
                    case 21:
                        Console.WriteLine("still ok");
                        break;
                    case 10:
                        Console.WriteLine("getting cold!");
                        break;
                    case 25:
                        Console.WriteLine("how about shorts");
                        break;
                    default:
                        Console.WriteLine("this is normal");
                        break;
                }
            }

            //ternary operator
            // condition ? first expression : second expression
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine(!string.IsNullOrEmpty(name) ? name : "no input provided");

        }
    }
}
