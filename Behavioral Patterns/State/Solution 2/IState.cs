using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
