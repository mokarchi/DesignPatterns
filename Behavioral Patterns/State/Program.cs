using System;
using State.Solution_1;
using State.StateScheme;
using StatePattern;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            //var mp3Player = new MP3PlayerContext();
            //mp3Player.Play();
            //Console.WriteLine(string.Format("The MP3 player state is {0}.", mp3Player.CurrentState));
            //mp3Player.Play();
            //Console.WriteLine(string.Format("The MP3 player state is {0}.", mp3Player.CurrentState));

            // The client code.
            //var context = new Context(new ConcreteStateA());
            //context.Request1();
            //context.Request2();

            var gumballmachine = new GumballMachine(5);
            gumballmachine.InsertQuarter();
            gumballmachine.TurnCrank();
            gumballmachine.InsertQuarter();
            gumballmachine.TurnCrank();
        }
    }
}
