using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.restaurant
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class Bar : IKitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go mix the drink
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
