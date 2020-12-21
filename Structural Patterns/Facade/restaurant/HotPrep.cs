using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.restaurant
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class HotPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go prep the hot entree
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
