using System;
using State.Solution_1;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var mp3Player = new MP3PlayerContext();
            mp3Player.Play();
            Console.WriteLine(string.Format("The MP3 player state is {0}.", mp3Player.CurrentState));
            mp3Player.Play();
            Console.WriteLine(string.Format("The MP3 player state is {0}.", mp3Player.CurrentState));
        }
    }
}
