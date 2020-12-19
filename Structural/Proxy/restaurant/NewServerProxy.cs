using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.restaurant
{
    /// <summary>
    /// The Proxy class, which can substitute for the Real Subject.
    /// </summary>
    class NewServerProxy : IServer
    {
        private string Order;
        private Server _server = new Server();

        public void TakeOrder(string order)
        {
            Console.WriteLine("New trainee server takes order for " + order + ".");
            Order = order;
        }

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New trainee cannot process payments yet!");
            _server.ProcessPayment(payment);
        }
    }
}
