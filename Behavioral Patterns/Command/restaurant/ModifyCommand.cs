using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command.restaurant
{
    /// <summary>
    /// A concrete command
    /// </summary>
    public class ModifyCommand : OrderCommand
    {
        public override void Execute(List<MenuItem> currentItems, MenuItem newItem)
        {
            var item = currentItems.Where(x => x.Name == newItem.Name).First();
            item.Price = newItem.Price;
            item.Amount = newItem.Amount;
        }
    }
}
