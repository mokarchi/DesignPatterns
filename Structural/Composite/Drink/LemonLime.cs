using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Drink
{
    /// <summary>
    /// Leaf class
    /// </summary>
    public class LemonLime : SoftDrink
    {
        public LemonLime(int calories) : base(calories) { }
    }
}
