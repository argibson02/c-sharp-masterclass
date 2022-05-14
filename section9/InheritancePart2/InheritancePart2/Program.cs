using System;

namespace InheritancePart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Post post1 = new Post("My title", true, "Alex");
            Console.WriteLine(post1.ToString());


            ImagePost post2 = new ImagePost("My new shoes", "Alex", "www.image.com", true);
            Console.WriteLine(post2.ToString());

            VideoPost post3 = new VideoPost("xtitle", "Alex G", "www.video.com/url", true, 20);
            Console.WriteLine(post3.ToString());

            Console.WriteLine("press any key to play a video.");
            Console.ReadKey();
            post3.Play();
            Console.WriteLine("press any key to stop a video.");
            Console.ReadKey();
            post3.Stop();



            Console.ReadLine();
        }
    }
}



/*
Challenge: add a dirvied class for video post
- need contrustor
- adjsut to string
- create instance of videopost


advanced
Use a Timer and Callback method here
create required fields
add memebr methods "play" which should write the current duration 
and "stop" method wihic should print vidoe stopped at x seconds
play the video after creating the instance and pause it when the use presses any key.


*/