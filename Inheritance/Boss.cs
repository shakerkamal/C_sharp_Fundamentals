using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Boss : Employee
    {
        public string CompanyCar { get; set; }

        //public Boss(string firstName, string lastName, int salary, string companyCar)
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.Salary = salary;
        //    this.CompanyCar = companyCar;
        //}

        //or using base and not to initialize the variables
        public Boss(string firstName, string lastName, int salary, string companyCar) : base(firstName, lastName, salary)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead()
        {
            Console.WriteLine("From your leader");
        }
    }
}
