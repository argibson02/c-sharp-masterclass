using System;

namespace sec4_challenge2
{
    internal class Program
    {
        //        Create an application with a score, highscore and a highscorePlayer.
        //Create a method which has two parameters, one for the score and one for the playerName.
        //When ever that method is called, it should be checked if the score of the player is higher than the highscore,
        //if so, "New highscore is + " score" and in another line "New highscore holder is " + playerName - should be written onto the console,
        //if not "The old highscore of " + highscore + " could not be broken and is still held by " + highscorePlayer.
        //Consider which variables are required globally and which ones locally.


        // static public int score = 0;
        static public int highscore = 0;
        static public string highscorePlayer = "";
        // static public string player = "";


        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to begin.");
            Console.ReadKey();

            checkScore(20, "alex");
            checkScore(20, "deer");
            checkScore(55, "todd");

            Console.Read();
        }

        static void checkScore(int score, string player)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = player;
                Console.WriteLine("Congrats! You beat the high score.");
                Console.WriteLine($"New high score: {highscore}.\n\rNew high score player: {highscorePlayer}");
            } else
            {
                Console.WriteLine($"You scored {score}. You didn't beat the high score! Better luck next time, {player}!");
                Console.WriteLine($"High score: {highscore}.\n\rHigh score player: {highscorePlayer}");

            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadKey();
        }


    }
}
