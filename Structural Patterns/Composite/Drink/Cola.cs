using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Drink
{
    /// <summary>
    /// Composite class
    /// </summary>
    public class Cola : SoftDrink
    {
        public Cola(int calories) : base(calories) { }
    }
}
