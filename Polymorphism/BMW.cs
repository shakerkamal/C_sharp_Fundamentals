using System;

namespace Polymorphism
{
    //if a class is sealed 
    // no class can inherit from it

    //A BMW is a Car   (is A relationship)
    class BMW : Car  //sealed - modifier
    {
        //memeber variable
        private string Brand;

        //props
        public string Model { get; set; }

        public BMW(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
            this.Brand = "BMW";
        }

        ///it reinitializes the method of base class

        // public new void ShowDetails()   
        // {
        //     System.Console.WriteLine($"This is a {this.Brand} car, model: {this.Model}, HP: {this.HP}, and it is a {this.Color} car");
        // }

        public override void ShowDetails()   //it reinitializes the method
        {
            System.Console.WriteLine($"This is a {this.Brand} car, model: {this.Model}, HP: {this.HP}, and it is a {this.Color} car");
        }

        public override void Repair()
        {
            System.Console.WriteLine($"{this.Brand} car was repaired!");
        }

        //using sealed modifier to stop overriding the method of base class to child class
        //sealed always called before override

        // public sealed override void Repair()
        // {
        //     System.Console.WriteLine($"{this.Brand} car was repaired!");
        // }
    }
}