using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility.Restaurant
{
    /// <summary>
    /// A concrete Handler class
    /// </summary>
    class HeadChef : Approver
    {
        public override void ProcessRequest(PurchaseOrder purchase)
        {
            if (purchase.Price < 1000)
            {
                Console.WriteLine("{0} approved purchase request #{1}",
                    this.GetType().Name, purchase.RequestNumber);
            }
            else if (Supervisor != null)
            {
                Supervisor.ProcessRequest(purchase);
            }
        }
    }
}
