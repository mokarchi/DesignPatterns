using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.restaurant
{
    /// <summary>
    /// RefinedAbstraction for a gluten free order
    /// </summary>
    public class SendGlutenFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Gluten-Free Order");
        }
    }
}
