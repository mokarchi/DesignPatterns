using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.restaurant
{
    /// <summary>
    /// RefinedAbstraction for a dairy-free order
    /// </summary>
    public class SendDairyFreeOrder : SendOrder
    {
        public override void Send()
        {
            _restaurant.Place("Dairy-Free Order");
        }
    }
}
