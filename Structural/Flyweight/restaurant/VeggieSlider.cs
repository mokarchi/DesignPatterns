using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.restaurant
{
    /// <summary>
    /// A ConcreteFlyweight class
    /// </summary>
    class VeggieSlider : Slider
    {
        public VeggieSlider()
        {
            Name = "Veggie Slider";
            Cheese = "Swiss";
            Toppings = "lettuce, onion, tomato, and pickles";
            Price = 1.99m;
        }

        public override void Display(int orderTotal)
        {
            Console.WriteLine("Slider #" + orderTotal
                              + ": " + Name + " - topped with "
                              + Cheese + " cheese and "
                              + Toppings + "! $" + Price.ToString());
        }

    }
}
