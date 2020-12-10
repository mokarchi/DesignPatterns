using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Cook
{
    /// <summary>
    /// The Strategy abstract class, which defines an 
    /// interface common to all supported strategy algorithms.
    /// </summary>
    abstract class CookStrategy
    {
        public abstract void Cook(string food);
    }
}
