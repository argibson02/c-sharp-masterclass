using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePart2
{
    internal class VideoPost : Post
    {
        public string VideoURL { get; set; }
        public int VideoLength { get; set; } 

        public static System.Timers.Timer vTimer;

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
            return String.Format($"{Id} - {Title} - by {SentUser}. URL: {VideoURL}");
        }
        public static void VideotTimer() { }



        public static void Play(Object VideoPost)
        {
            Console.WriteLine($"Remaining video lenght:{VideoPost.VideoLength}");
        }

        public static void Stop()
        {

        }

    }
}
