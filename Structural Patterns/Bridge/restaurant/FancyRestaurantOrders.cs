using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.restaurant
{
    /// <summary>
    /// ConcreteImplementor for an ordering system at a fancy restaurant.
    /// </summary>
    public class FancyRestaurantOrders : IOrderingSystem
    {
        public void Place(string order)
        {
            Console.WriteLine("Placing order for "
                              + order + " at the Fancy Restaurant.");
        }
    }
}
