using System;
using Facade.creditworthiness;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);
            Console.WriteLine("\n" + customer.Name +" has been " + (eligible ? "Approved" : "Rejected"));
        }
    }
}
