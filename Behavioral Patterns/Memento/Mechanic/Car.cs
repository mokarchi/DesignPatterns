using System;
using System.Collections.Generic;
using System.Text;

namespace Mechanic
{
    public class Car
    {
        private string state; public Car(string state)
        {
            this.state = state;
        }
        public string getState()
        {
            return state;
        }
    }
}
