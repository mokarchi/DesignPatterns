using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class MoneyBackCreditCard : CreditCard
    {
        private readonly string _cardType;
        private int _creditLimit;
        private int _annualCharge;

        public MoneyBackCreditCard(int creditLimit, int annualCharge)
        {
            _cardType = "MoneyBack";
            _creditLimit = creditLimit;
            _annualCharge = annualCharge;
        }
        public string CardType => _cardType;

        public int CreditLimit { get => _creditLimit; set => _creditLimit = value; }
        public int AnnualCharge { get => _annualCharge; set => _annualCharge = value; }
    }
}
