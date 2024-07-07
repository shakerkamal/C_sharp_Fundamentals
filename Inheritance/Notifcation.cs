using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Notifcation : INotification
    {
        private string sender;
        private string message;
        private DateTime date;

        //deafult constructor
        public Notifcation()
        {
            this.sender = "Admin";
            this.message = "Chill!";
            this.date = DateTime.Now;
        }

        public Notifcation(string sender, string message, DateTime date)
        {
            this.sender = sender;
            this.message = message;
            this.date = date;
        }
        public string GetDate()
        {
            return date.ToString();
        }

        public void Notify()
        {
            Console.WriteLine($"New notification: {this.sender}, {this.message}, {this.date}");
        }

        public void CheckMessage()
        {
            Console.WriteLine($"New Message: {this.message}");
        }
    }
}
