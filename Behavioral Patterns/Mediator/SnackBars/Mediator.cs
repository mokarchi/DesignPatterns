using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.SnackBars
{
    /// <summary>
    /// The Mediator interface, which 
    /// defines a send message method 
    /// which the concrete mediators must implement.
    /// </summary>
    interface Mediator
    {
        void SendMessage(string message, ConcessionStand concessionStand);
    }
}
