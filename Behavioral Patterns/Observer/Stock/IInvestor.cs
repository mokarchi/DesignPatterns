using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Stock
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    interface IInvestor
    {
        void Update(Stock stock);
    }
}
