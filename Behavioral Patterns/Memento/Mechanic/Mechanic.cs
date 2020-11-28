using System;
using System.Collections.Generic;
using System.Text;

namespace Mechanic
{
    public class Mechanics
    {
        private string state; public void setState(string state)
        {
            Console.WriteLine(state); this.state = state;
        }
        public Car save()
        {
            return new Car(state);
        }
        public void restore(Car m)
        {
            state = m.getState();
            Console.WriteLine("Returning to the previous work.");
            Console.WriteLine(state);
        }
    }
}
