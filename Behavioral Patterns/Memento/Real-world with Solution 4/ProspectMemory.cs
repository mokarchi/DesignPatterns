using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Real_world_with_Solution_4
{
    /// <summary>
    /// The 'Caretaker' class
    /// </summary>
    public class ProspectMemory
    {
        private Memento _memento;

        public Memento Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
