using System;
using System.Collections.Generic;
using System.Text;

namespace MementoScheme
{
    public class Originator
    {
        private string state; public void setState(string state)
        {
            Console.WriteLine("Originator: Setting state to " + state);
            this.state = state;
        }
        public Memento save()
        {
            Console.WriteLine("Originator: Saving to Memento.");
            return new Memento(state);
        }
        public void restore(Memento m)
        {
            state = m.getState();
            Console.WriteLine("Originator: State after restoring from Memento: " + state);
        }
    }
}
