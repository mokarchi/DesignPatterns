using System;
using Bridge.DataObject;
using Bridge.restaurant;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Create RefinedAbstraction
            //Customers customers = new Customers("Chicago");
            //// Set ConcreteImplementor
            //customers.Data = new CustomersData();
            //// Exercise the bridge
            //customers.Show();
            //customers.Next();
            //customers.Show();
            //customers.Next();
            //customers.Show();
            //customers.Add("Henry Velasquez");
            //customers.ShowAll();

            SendOrder _sendOrder = new SendDairyFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();

            _sendOrder = new SendGlutenFreeOrder();
            _sendOrder._restaurant = new DinerOrders();
            _sendOrder.Send();

            _sendOrder._restaurant = new FancyRestaurantOrders();
            _sendOrder.Send();
        }
    }
}
