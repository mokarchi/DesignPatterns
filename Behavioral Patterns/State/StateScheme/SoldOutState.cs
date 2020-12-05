using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class SoldOutState : IState
    {
        private readonly GumballMachine Machine;

        public SoldOutState(GumballMachine gumballMachine)
        {
            Machine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("Can't dispense when out of stock");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Can't eject when sold out");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Sorry! Sold Out");
        }

        public void TurnCrank()
        {
            Console.WriteLine("turning crank achieves nothing");
        }
    }
}
