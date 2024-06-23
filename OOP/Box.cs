using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Box
    {
        /*
        private int length;
        public int height;
        public int width;
        public int volume;

        //set function to assign length variable
        public void SetLength(int length)
        {
            this.length = length;
        }

        //getter function to return 
        public int GetLength()
        {
            return this.length;
        }
        */

        private int length;
        private int height;
        private int width;
        //private int volume;

        // readonly public property                    ----> Encapsulation
        public int Volume
        {
            get
            {
                return length * height * width;
            }
        }
        public string Color { get; set; }

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }
        /*
        //property
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        //expression
        public int Length
        {
            get => length;
            set => length = value;
        }
        */

        public void DIsplay()
        {
            //volume = length * height * width;
            Console.WriteLine("The box is " + Color + " color and " + "Length is {0}, height is {1}, and width is {2} so the vloume is {3}", length, height, width, Volume);
        }
    }
}
