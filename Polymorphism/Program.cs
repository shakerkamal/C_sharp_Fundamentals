using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // var cars = new List<Car>{
            //     new BMW(550, "Ash", "2015S"),
            //     new Audi(650, "Blue", "A8")
            // };

            // foreach(var car in cars){
            //     car.Repair();
            //     car.ShowDetails();
            // }

            Car c = new Car(450, "Black");
            c.ShowDetails();
            c.Repair();

            Car bmw = new BMW(569, "Red", "M5");
            bmw.ShowDetails();
            //==>  if not overriden then > The HP of the car is 569, and it is a Red car
            //==> if overriden then > This is a BMW car, model: M5, HP: 569, and it is a Red car
            bmw.Repair();
            //==>  if not overriden then > Car was repaired!
            //==> if overriden then > BMW car was repaired!

            BMW b = new BMW(589, "Ash", "M3");
            b.ShowDetails();
            b.Repair();
            b.SetCarInfo(1234, "kotlin");
            b.GetCarInfo();

            Audi a = new Audi(647, "Green", "A8");
            a.ShowDetails();
            a.Repair();
            a.SetCarInfo(1456, "Xavier");
            a.GetCarInfo();

            //casting object
            Car c1 = (Car)b;
            c1.ShowDetails();

            M3 m3 = new M3(456, "Orange", "M3");
            m3.Repair();

            Console.ReadKey();
        }
    }
}
