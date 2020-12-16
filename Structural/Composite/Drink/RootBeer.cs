using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Drink
{
    /// <summary>
    /// Composite class
    /// </summary>
    public class RootBeer : SoftDrink
    {
        public RootBeer(int calories) : base(calories) { }
    }
}
