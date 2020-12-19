using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.restaurant
{
    /// <summary>
    /// Each section of the kitchen must implement this interface.
    /// </summary>
    interface IKitchenSection
    {
        FoodItem PrepDish(int DishID);
    }
}
