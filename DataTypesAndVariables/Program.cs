using System;

namespace DataTypesAndVariables
{
    class Program
    {
        //constants as fields
        const double PI = 3.14167;
        const int daysInWeek = 7;
        const string mybirthday = "20.06.1994";
        static void Main(string[] args)
        {
            ///array declaration
            //array of any size
            string[] MyGamesOf2013 = {"GTAV", "Battlefield3"}; 
            //array of fixed size
            string[] MyMoveisOf2013 = new string[3] {"The Amazing Spiderman", "The Expendables 2", "Rise of the planet of the apes"}; 
            
            //switch-case
            int year = Int32.Parse(Console.ReadLine());
            switch(year){
                case 2019:
                System.Console.WriteLine("It's 2019");
                break;
                case 2020:
                System.Console.WriteLine("It's 2020");
                break;
                case 2022:
                System.Console.WriteLine("It's Corona year");
                break;
                default:
                System.Console.WriteLine("Well no match!");
                break;
            }
            //explicit conversion
            int number = 112232334;
            long longnum = number;
            System.Console.WriteLine(longnum);

            //implicit conversion
            double dec = 1444.456;
            float f = 134.45F;
            int doubnum;
            int flotnum;
            //type casting
            flotnum = (int)f;
            doubnum = (int)dec;
            System.Console.WriteLine(flotnum);
            System.Console.WriteLine(doubnum);

            //parsing
            string num1 = "15";
            string num2 = "10";
            int res = Int32.Parse(num1) + Int32.Parse(num2);
            System.Console.WriteLine(res);

            //string formatting
            Console.WriteLine(string.Format("{0:C}", 5));

            System.Console.WriteLine("My birthday will always be: {0}", mybirthday);
        }
    }
}
