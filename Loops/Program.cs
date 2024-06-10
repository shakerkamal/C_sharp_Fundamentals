using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i =0; i< 10; i++)
            //{
            //    Console.WriteLine("Hello World! {0}",i );
            //}
            int counter = 0;
            //do
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //} while (counter < 10);

            while(counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.Read();
        }
    }
}
