using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Drink
{
    /// <summary>
    /// Leaf class
    /// </summary>
    public class CherryCola : SoftDrink
    {
        public CherryCola(int calories) : base(calories) { }
    }
}
