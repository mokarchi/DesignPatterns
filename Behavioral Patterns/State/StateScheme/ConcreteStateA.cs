using System;
using System.Collections.Generic;
using System.Text;

namespace State.StateScheme
{
    /// <summary>
    /// Concrete States implement various behaviors, associated with a state of the Context.
    /// </summary>
    class ConcreteStateA : State
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.");
            this._context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            Console.WriteLine("ConcreteStateA handles request2.");
        }
    }
}
