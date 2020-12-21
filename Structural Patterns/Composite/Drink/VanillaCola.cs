using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Drink
{
    /// <summary>
    /// Leaf class
    /// </summary>
    public class VanillaCola : SoftDrink
    {
        public VanillaCola(int calories) : base(calories) { }
    }
}
