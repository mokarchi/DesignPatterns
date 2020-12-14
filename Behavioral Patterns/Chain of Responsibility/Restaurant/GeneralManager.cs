using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility.Restaurant
{
    /// <summary>
    /// A concrete Handler class
    /// </summary>
    class GeneralManager : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 10000)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, purchase.RequestNumber);
            }
            else
            {
                Console.WriteLine(
                    "Purchase request #{0} requires an executive meeting!",
                    purchase.RequestNumber);
            }
        }
    }
}
