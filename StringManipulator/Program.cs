using System;

namespace StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Test123-1";
            string t = "Test123";
            string[] vals = s.Split("-");
            string[] ts = t.Split("-");

            foreach(var v in vals){
                System.Console.WriteLine(v);
            }

            foreach(var r in ts){
                System.Console.WriteLine(r);
            }
         }
    }
}
