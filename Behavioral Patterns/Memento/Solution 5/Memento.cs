using System;
using System.Collections.Generic;
using System.Text;

namespace MementoScheme
{
    public class Memento
    {
        private string state; public Memento(string state)
        {
            this.state = state;
        }
        public string getState()
        {
            return state;
        }
    }
}
