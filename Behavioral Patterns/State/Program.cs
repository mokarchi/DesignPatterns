using StatePattern;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var gumballmachine = new GumballMachine(5);
            gumballmachine.InsertQuarter();
            gumballmachine.TurnCrank();
            gumballmachine.InsertQuarter();
            gumballmachine.TurnCrank();
        }
    }
}
