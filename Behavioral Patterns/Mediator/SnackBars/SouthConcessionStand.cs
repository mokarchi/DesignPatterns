using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.SnackBars
{
    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    class SouthConcessionStand : ConcessionStand
    {
        public SouthConcessionStand(Mediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            Console.WriteLine("South Concession Stand sends message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("South Concession Stand gets message: " + message);
        }
    }
}
