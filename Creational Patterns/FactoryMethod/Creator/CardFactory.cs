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
