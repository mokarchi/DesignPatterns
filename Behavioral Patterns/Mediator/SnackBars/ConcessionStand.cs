using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.SnackBars
{
    /// <summary>
    /// The Colleague abstract class, representing 
    /// an entity involved in the conversation 
    /// which should receive messages.
    /// </summary>
    abstract class ConcessionStand
    {
        protected Mediator mediator;

        public ConcessionStand(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
