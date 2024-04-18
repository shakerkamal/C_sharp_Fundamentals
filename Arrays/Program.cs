using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            //initialize an array of fixed size
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = i;
                Console.WriteLine($"Values of the loop: {i}");
            }

            foreach (int k in numbers)
            {
                Console.WriteLine($"printing from foreach loop: {k}");
            }

            //initialize array with values
            string[] names = { "Amir", "Sohan", "Micheal" };

            // another way of initializeing an array
            string[] grades = new string[] { "A", "B", "C" };

            Console.WriteLine("Hello World!");

            //declare 2d array
            string[,] matrix;

            //declare 3d array
            int[,,] threeD;

            //two dims array
            int[,] initialized = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7, 8,9 }
            };
            Console.WriteLine("Value at [0][1] index is: {0}", initialized[0, 1]);

            string[,,] persons = new string[,,]
            {
                {
                    {"alice","bob"}, // [0 0 0] [0 0 1]
                    {"xander", "potter"}  // [0 1 0] [0 1 1]
                },
                {
                    {"simon", "haeley" },
                    {"kirsten","sony"}
                }
            };

            //rank returns the dimension of the array
            Console.WriteLine($"the dimension of the array persons {persons.Rank}");

            Console.WriteLine("Value at [0][1][1] index is: {0}", persons[0, 1, 0]);

            Console.WriteLine("Jagged Array");

            //jagged array--> an array inside an array

            //declare jagged array
            int[][] jaArray = new int[3][];

            jaArray[0] = new int[3];
            jaArray[1] = new int[5];
            jaArray[2] = new int[2];

            jaArray[0] = new int[3] { 1, 2, 4 };
            jaArray[1] = new int[5] { 3, 6, 8, 9, 10 };
            jaArray[2] = new int[2] { 13, 17 };

            //with initialized values
            int[][] jaggedArray = new int[][]
            {
                new int[] { 1, 2, 4 },
                new int[5] { 3, 6, 8, 9, 10 },
                new int[2] { 13, 17 }
            };

            Console.WriteLine($"the value in the middle of the first entry {jaggedArray[0][1]}");

            int count = 0;
            foreach (int[] v in jaggedArray)
            {
                Console.WriteLine($"elements in index {count}");
                foreach (int value in v)
                {
                    Console.WriteLine(value);
                }
                count++;
            }

            //array list
            Console.WriteLine("ARRAY LIST");

            ArrayList al = new ArrayList();                 //====> generic arrays which holds multiple data types

            //array list methods
            al.Add(25);
            al.Add("Tst");
            al.Add(13.45);
            Console.WriteLine(al.IndexOf(25));
        }
    }
}
