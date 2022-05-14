using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InheritancePart2
{
    internal class VideoPost : Post
    {
        protected string VideoURL { get; set; }
        protected int VideoLength { get; set; }


        protected bool IsPlaying = false;
        protected int currentDuration = 0;

        Timer timer;

        public VideoPost() { }

        public VideoPost(string title, string sentUser, string url, bool isPublic, int videoLength)
        {
            this.Id = GetNextId();
            this.Title = title;
            this.SentUser = sentUser;
            this.IsPublic = isPublic;


            this.VideoURL = url;
            this.VideoLength = videoLength;

        }

        public override string ToString()
        {
            return String.Format($"{Id} - {Title} - by {SentUser}. URL: {VideoURL}. Length: {VideoLength}");
        }


        public void Play()
        {
            if (!IsPlaying)
            {
                IsPlaying = true;
                Console.WriteLine("playing...");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }

        }


        private void TimerCallback(Object o)
        {
            if (currentDuration < VideoLength)
            {
                currentDuration++;
                Console.WriteLine($"Video at timestamp: {currentDuration}");
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }



        public void Stop()
        {

            Console.WriteLine($"Stopped at {currentDuration}");
            currentDuration = 0;
            timer.Dispose();

        }

    }
}
