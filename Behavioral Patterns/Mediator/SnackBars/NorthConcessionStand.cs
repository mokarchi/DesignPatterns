using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator.SnackBars
{
    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    class NorthConcessionStand : ConcessionStand
    {
        // Constructor
        public NorthConcessionStand(Mediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            Console.WriteLine("North Concession Stand sends message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("North Concession Stand gets message: " + message);
        }
    }
}
