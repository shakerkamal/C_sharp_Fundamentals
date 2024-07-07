using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Trainee : Employee
    {
        public int WorkingHours { get; set; }

        public Trainee(string firstName, string lastName, int salary, int workingHours) : base(firstName, lastName, salary)
        {
            this.WorkingHours = workingHours;
        }

        public void Learn()
        {
            Console.WriteLine("Trainee Learning");
        }

        public override void Work()
        {
            Console.WriteLine($"I am working {WorkingHours} hours");
        }
    }
}
