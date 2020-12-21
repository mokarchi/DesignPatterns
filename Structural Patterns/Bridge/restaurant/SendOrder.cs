using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge.restaurant
{
    /// <summary>
    /// Abstraction which represents the sent order 
    /// and maintains a reference to the restaurant where the order is going.
    /// </summary>
    public abstract class SendOrder
    {
        //Reference to the Implementor
        public IOrderingSystem _restaurant;

        public abstract void Send();
    }
}
