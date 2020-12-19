using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.restaurant
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class ColdPrep : IKitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go prep the cold item
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
