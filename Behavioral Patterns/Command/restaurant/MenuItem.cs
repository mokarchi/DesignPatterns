using System;
using System.Collections.Generic;
using System.Text;

namespace Command.restaurant
{
    /// <summary>
    /// Represents an item being ordered from this restaurant.
    /// </summary>
    public class MenuItem
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }

        public MenuItem(string name, int amount, double price)
        {
            Name = name;
            Amount = amount;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine("\nName: " + Name);
            Console.WriteLine("Amount: " + Amount.ToString());
            Console.WriteLine("Price: $" + Price.ToString());
        }
    }
}
