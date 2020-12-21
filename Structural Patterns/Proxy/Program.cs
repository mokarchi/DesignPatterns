using System;
using Proxy.Math;
using Proxy.restaurant;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create math proxy
            //MathProxy proxy = new MathProxy();
            //Console.WriteLine("4 + 2 = " + proxy.Add(4, 2));
            //Console.WriteLine("4 - 2 = " + proxy.Sub(4, 2));
            //Console.WriteLine("4 * 2 = " + proxy.Mul(4, 2));
            //Console.WriteLine("4 / 2 = " + proxy.Div(4, 2));

            NewServerProxy proxy = new NewServerProxy();

            //Manage orders from a table
            Console.WriteLine("What would you like to order? ");
            string order = Console.ReadLine();
            proxy.TakeOrder(order);
            Console.WriteLine("Sure thing!  Here's your " + proxy.DeliverOrder() + ".");
            Console.WriteLine("How would you like to pay?");
            string payment = Console.ReadLine();
            proxy.ProcessPayment(payment);
        }
    }
}
