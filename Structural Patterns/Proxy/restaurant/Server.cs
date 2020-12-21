using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.restaurant
{
    /// <summary>
    /// The RealSubject class which the Proxy can stand in for
    /// </summary>
    class Server : IServer
    {
        private string Order;
        public void TakeOrder(string order)
        {
            Console.WriteLine("Server takes order for " + order + ".");
            Order = order;
        }

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for order (" + payment + ") processed.");
        }
    }

}
