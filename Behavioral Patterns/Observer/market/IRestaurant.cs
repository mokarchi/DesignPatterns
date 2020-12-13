using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.market
{
    /// <summary>
    /// The Observer interface
    /// </summary>
    interface IRestaurant
    {
        void Update(Veggies veggies);
    }
}
