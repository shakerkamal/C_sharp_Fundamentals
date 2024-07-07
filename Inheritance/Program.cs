using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Post p1 = new Post();
            //Console.WriteLine(p1.ToString());
            //Post p2 = new Post("My first post", "Shaker", true);
            //Console.WriteLine(p2.ToString());
            //ImagePost ip1 = new ImagePost("My first phone", "Shaker", true, "https://images.com/iphone");
            //Console.WriteLine(ip1.ToString());
            //Console.ReadKey();

            //VideoPost vp = new VideoPost("first video", "Chandler", true, "https://youtube.com/Xy2RtU234Z=",15);
            //Console.WriteLine(vp.ToString());
            //vp.Play();
            //Console.WriteLine("Press any key to stop the video");
            //Console.ReadKey();
            //vp.Stop();

            Employee e = new Employee("X", "Y", 36000);
            e.Work();
            e.Pause();

            Boss b = new Boss("Simon", "Lynn", 450000, "Ford");
            b.Lead();
            b.Work();
            b.Pause();

            Trainee t = new Trainee("Kirsten", "Ewen", 15000,25);
            t.Learn();
            t.Work();

            Notifcation n = new Notifcation();  //"Programmer","Check your inbox",DateTime.Now
            n.Notify();
            Console.WriteLine(n.GetDate()); ;
        }
    }
}
