using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class ImagePost :  Post    // inheriting from post class
    {
        public string ImageUrl { get; set; }

        public ImagePost()
        {

        }
        public ImagePost(string title, string sendByUser, bool isPublic, string imageUrl)
        {
            Id = GetNextId();
            this.Title = title;
            this.SendByUserName = sendByUser;
            this.IsPublic = isPublic;
            this.ImageUrl = imageUrl;
        }

        public override string ToString()
        {
            return string.Format($"{Id} - {Title} - {ImageUrl} - {SendByUserName}");
        }
    }
}
