using System;
using System.Collections.Generic;
using System.Text;

namespace Command.restaurant
{
    /// <summary>
    /// The Command abstract class
    /// </summary>
    public abstract class OrderCommand
    {
        public abstract void Execute(List<MenuItem> order, MenuItem newItem);
    }
}
