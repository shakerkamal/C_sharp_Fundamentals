using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an object using Human class
            // an instance of Human
            //Human alice = new Human("Alice", "Wayne","blue",29);
            ////alice.FirstName = "Alice";
            ////alice.LastName = "WonderLand";
            //alice.Introduce();

            ////another instance
            //Human bob = new Human("Bob", "Dylan", "green", 25);
            ////bob.FirstName = "Bob";
            //bob.Introduce();

            MultipleConstructor withoutParams = new MultipleConstructor();
            withoutParams.Introduce();

            MultipleConstructor withParams = new MultipleConstructor("Harry","Potter","ash",15);
            withParams.Introduce();

            MultipleConstructor withAge = new MultipleConstructor(40);
            withAge.Introduce();


            Box box = new Box(10, 7, 5);
            //box.SetLength(10);
            //Console.WriteLine(box.GetLength());
            //box.height = 7;
            //box.width = 8;
            box.Color = "Green";

            //trying to set the volume property
            //box.Volume =   --> will say that cannot set value to this prop since it is readonly
            box.DIsplay();

            //destructor example
            Console.WriteLine("Destructor Example");

            MembersAndDestructor m1 = new MembersAndDestructor();
            m1.Introduce(true);

            //Console.ReadKey();
        }
    }
}
