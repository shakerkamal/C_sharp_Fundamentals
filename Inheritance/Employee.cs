using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Employee
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected int Salary { get; set; }

        public Employee()
        {
            this.FirstName = "Chandler";
            this.LastName = "Bing";
            this.Salary = 123000;
        }

        public Employee(string firstName, string lastName, int salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("Working!");
        }

        public void Pause()
        {
            Console.WriteLine("Taking a break");
        }
    }
}
