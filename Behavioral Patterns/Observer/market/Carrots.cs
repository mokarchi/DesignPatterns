using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.market
{
    /// <summary>
    /// The ConcreteSubject class
    /// </summary>
    class Carrots : Veggies
    {
        public Carrots(double price) : base(price) { }
    }
}
