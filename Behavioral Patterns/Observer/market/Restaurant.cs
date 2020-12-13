using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.market
{
    /// <summary>
    /// The ConcreteObserver class
    /// </summary>
    class Restaurant : IRestaurant
    {
        private string _name;
        private Veggies _veggie;
        private double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Veggies veggie)
        {
            Console.WriteLine("Notified {0} of {1}'s "
                               + " price change to {2:C} per pound.",
                               _name, veggie.GetType().Name, veggie.PricePerPound);
            if (veggie.PricePerPound < _purchaseThreshold)
            {
                Console.WriteLine(_name + " wants to buy some "
                                  + veggie.GetType().Name + "!");
            }
        }
    }
}
