using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.restaurant
{
    /// <summary>
    /// The actual "Facade" class, which hides the 
    /// complexity of the KitchenSection classes.
    /// After all, there's no reason a patron 
    /// should order each part of their meal individually.
    /// </summary>
    class Server
    {
        private ColdPrep _coldPrep = new ColdPrep();
        private Bar _bar = new Bar();
        private HotPrep _hotPrep = new HotPrep();

        public Order PlaceOrder(Patron patron,
                                int coldAppID,
                                int hotEntreeID,
                                int drinkID)
        {
            Console.WriteLine("{0} places order for cold app #"
                              + coldAppID.ToString()
                              + ", hot entree #" + hotEntreeID.ToString()
                              + ", and drink #" + drinkID.ToString() + ".");

            Order order = new Order();

            order.Appetizer = _coldPrep.PrepDish(coldAppID);
            order.Entree = _hotPrep.PrepDish(hotEntreeID);
            order.Drink = _bar.PrepDish(drinkID);

            return order;
        }
    }
}
