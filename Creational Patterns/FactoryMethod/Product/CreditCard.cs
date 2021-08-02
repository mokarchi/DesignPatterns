namespace FactoryMethod
{
    public interface CreditCard
    {
        string CardType { get; }
        int CreditLimit { get; set; }
        int AnnualCharge { get; set; }
    }
}
