using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Post
    {
        //it holds the current id of the post object
        private static int currentPostId;

        //prop   --> properties which can only be accessed by the base class and derived class
        protected int Id { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        private enum PostType{
            Social,
            Political,
            Economic,
            Business
        } 

        // default constructor. If a derived class does not invoke
        // a base-class constructor, then the default constructor is called implicitly
        public Post()
        {
            Id = 0;
            Title = "Hello there!";
            IsPublic = true;
            SendByUserName = "Shaker";

            Console.WriteLine("Default constructor from base class");
        }

        // overloaded constructor with parameters
        public Post(string title, string sendByUser, bool isPublic)
        {
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUserName = sendByUser;
            this.IsPublic = isPublic;
        }
        protected int GetNextId()
        {
            return ++currentPostId;
        }
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return string.Format($"{this.Id} - {this.Title} - {this.SendByUserName}");
        }
    }
}
