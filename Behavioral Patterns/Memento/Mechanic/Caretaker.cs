using System;
using System.Collections.Generic;
using System.Text;

namespace Mechanic
{
    public class Caretaker
    {
        private List<Car> mementos = new List<Car>(); public void addMemento(Car m)
        {
            mementos.Add(m);
        }
        public Car getMemento(int index)
        {
            return mementos[index];
        }
    }
}
