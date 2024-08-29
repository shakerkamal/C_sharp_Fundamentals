using System;

namespace Polymorphism
{
    class Car
    {
        protected int HP { get; set; }
        protected string Color { get; set; }

        // HAS A relationship
        protected CarInfo carInfo = new CarInfo();

        public void SetCarInfo(int id, string owner)
        {
            carInfo.Id = id;
            carInfo.Owner = owner;
        }

        public void GetCarInfo()
        {
            System.Console.WriteLine($"this car has id {carInfo.Id}, owned by {carInfo.Owner}");
        }
        //default constructor
        public Car()
        {

        }

        //overloaded constructor
        public Car(int hp, string color)
        {
            this.HP = hp;
            this.Color = color;
        }

        public virtual void ShowDetails()       //========> to let child class override the method use 'virtual'
        {
            System.Console.WriteLine($"The HP of the car is {this.HP}, and it is a {this.Color} car");
        }

        public virtual void Repair()       //======> to let child class override the method
        {
            System.Console.WriteLine("Car was repaired!");
        }
    }
}