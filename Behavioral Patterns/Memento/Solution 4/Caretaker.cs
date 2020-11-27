using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Solution_4
{
    public class Caretaker
    {
        private Memento _memento;

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
