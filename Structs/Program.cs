using System;

namespace Structs
{
    //structs are value types
    //cannot have default constructor
    //can implement interfaces
    //can have inheritance
    //can have public, private access modifier
    //can not have a null reference(unless NULLABLE is used)
    struct Game
    {
        public string Name;
        public string Developer;
        public double Rating;
        public string ReleaseDate;

        public Game(string name, string developer, double rating, string date){
            this.Name = name;
            this.Developer = developer;
            this.Rating = rating;
            this.ReleaseDate = date;
        }

        public void Display(){
            System.Console.WriteLine($"Game: {Name}, Developer: {Developer}, Rating: {Rating}, ReleaseDate: {ReleaseDate}");
        }
    }
    //class is a reference type
    //an object a class can be empty
    class Program
    {
        static void Main(string[] args)
        {
            Game g1;
            ///g1.Display();
            //---> will display error message as g1 is unassigned
            //all the variables must be assigned before being called
            g1.Name = "Pokemon GO";
            g1.Developer = "Inc";
            g1.Rating = 4.7;
            g1.ReleaseDate = "12-06-2015";

            g1.Display();

            Game g2 = new Game("FIFA 21", "EA Sports",4.2,"15-02-2020");
            g2.Display();
            
        }
    }
}
