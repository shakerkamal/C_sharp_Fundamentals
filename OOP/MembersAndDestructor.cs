using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OOP
{
    class MembersAndDestructor
    {
        //private field
        private string memberName;
        private string jobTitle;
        private int salary = 60000;

        //public field
        public int age;

        //member property
        public string JobTitle {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        //public member method to be called from other classes 
        public void Introduce(bool isFriend)
        {
            if (isFriend)
            {
                SharePrivateInfo();
            }
            else
            {
                Console.WriteLine($"I am from {memberName} group, my jobtitle is {jobTitle} and I am {age} years old");
                Console.WriteLine("How are you?");
            }
        }

        private void SharePrivateInfo()
        {
            Console.WriteLine($"My Current Salary is {salary}");
        }

        //member constructor
        public MembersAndDestructor()
        {
            age = 30;
            memberName = "Joey";
            salary = 60000;
            jobTitle = "Senior Developer";
            Console.WriteLine("Object Created");
        }

        //finalizer - destructor
        //will only we initalized once and called once
        //can not be overloaded or inherited
        //cannote be called
        ~MembersAndDestructor()
        {
            //clean up statements
            Console.WriteLine("Decontructor called");
            Debug.Write("Destructor called");
        }
    }
}
