using System;

namespace Polymorphism
{
    class Audi : Car
    {
        //memeber variable
        private string Brand;

        //props
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
            this.Brand = "Audi";
        }

        ///it reinitializes the method of base class 
        // public new void ShowDetails()
        // {
        //     System.Console.WriteLine($"This is a {this.Brand} car, model: {this.Model}, HP: {this.HP}, and it is a {this.Color} car");
        // }

        //overriding base class method
        public override void ShowDetails()
        {
            System.Console.WriteLine($"This is a {this.Brand} car, model: {this.Model}, HP: {this.HP}, and it is a {this.Color} car");
        }

        public override void Repair()
        {
            System.Console.WriteLine($"{this.Brand} car was repaired!");
        }
    }
}