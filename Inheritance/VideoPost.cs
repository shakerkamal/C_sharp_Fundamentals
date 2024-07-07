using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Inheritance
{
    class VideoPost : Post
    {
        //member variables
        protected bool isPlaying = false;
        protected int currentDuration = 0;
        Timer timer;

        //props
        public string VideoUrl { get; set; }
        public int Length { get; set; }

        public VideoPost()
        {

        }

        public VideoPost(string title, string sendByUser, bool isPublic, string videoUrl, int length)
        {
            this.Id = GetNextId();
            this.Title = title;
            this.SendByUserName = sendByUser;
            this.IsPublic = isPublic;
            this.VideoUrl = videoUrl;
            this.Length = length;
        }

        public override string ToString()
        {
            return string.Format($"{Id} - {Title} - {VideoUrl} - {Length} - by {SendByUserName}");
        }

        public void Play()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }
            

        }

        private void TimerCallback(object state)
        {
            if(currentDuration < Length)
            {
                currentDuration++;
                Console.WriteLine($"Video at {currentDuration}s");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if (isPlaying)
            {
                isPlaying = false;
                Console.WriteLine($"Stopped the timer at {currentDuration}s");
                currentDuration = 0;
                //stop the timer
                timer.Dispose();
            }
        }
    }
}
