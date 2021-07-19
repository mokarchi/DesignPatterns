using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    abstract class CardFactory
    {
        protected abstract CreditCard GetCreditCard();
        public CreditCard CreateProduct()
        {
            return this.GetCreditCard();
        }
    }
}
