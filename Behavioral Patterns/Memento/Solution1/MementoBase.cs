using System;

namespace Memento
{
    /// <summary>
    /// Parent Of Other Classes
    /// </summary>
    abstract class MementoBase
    {
        /// <summary>
        /// Keep States
        /// </summary>
        protected Guid mementoKey = Guid.NewGuid();
        abstract public void SaveMemento(Memento memento);
        abstract public void RestoreMemento(Memento memento);
    }
}
