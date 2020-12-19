using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.restaurant
{
    /// <summary>
    /// The Flyweight class
    /// </summary>
    abstract class Slider
    {
        protected string Name;
        protected string Cheese;
        protected string Toppings;
        protected decimal Price;

        public abstract void Display(int orderTotal);
    }
}
