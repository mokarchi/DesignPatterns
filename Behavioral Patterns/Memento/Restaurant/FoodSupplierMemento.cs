using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Restaurant
{
    /// <summary>
    /// The Memento class
    /// </summary>
    class FoodSupplierMemento
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public FoodSupplierMemento(string name, string phone, string address)
        {
            Name = name;
            PhoneNumber = phone;
            Address = address;
        }
    }
}
