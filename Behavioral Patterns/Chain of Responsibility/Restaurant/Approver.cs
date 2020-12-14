using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Responsibility.Restaurant
{
    /// <summary>
    /// The Handler abstract class.  
    /// Every class which inherits from this 
    /// will be responsible for a kind of request for the restaurant.
    /// </summary>
    abstract class Approver
    {
        protected Approver Supervisor;

        public void SetSupervisor(Approver supervisor)
        {
            this.Supervisor = supervisor;
        }

        public abstract void ProcessRequest(PurchaseOrder purchase);
    }
}
