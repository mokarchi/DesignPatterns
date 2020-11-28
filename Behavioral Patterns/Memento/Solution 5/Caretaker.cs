using System;
using System.Collections.Generic;
using System.Text;

namespace MementoScheme
{
    public class Caretaker
    {
        private List<Memento> mementos = new List<Memento>(); public void addMemento(Memento m)
        {
            mementos.Add(m);
        }
        public Memento getMemento(int index)
        {
            return mementos[index];
        }
    }
}
