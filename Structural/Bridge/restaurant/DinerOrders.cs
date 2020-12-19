using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.restaurant
{
    /// <summary>
    /// ConcreteImplementor for an ordering system at a diner.
    /// </summary>
    public class DinerOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for " + order + " at the Diner.");
        }
    }
}
