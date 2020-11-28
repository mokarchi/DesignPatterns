using System;

namespace MementoScheme
{
    /// <summary>
    /// The Concrete Memento contains the infrastructure for storing the Originator's state.
    /// </summary>
    class ConcreteMemento : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        /// <summary>
        /// The Originator uses this method when restoring its state.
        /// </summary>
        public string GetState()
        {
            return this._state;
        }

        /// <summary>
        /// The rest of the methods are used by the Caretaker to display metadata.
        /// </summary>
        public string GetName()
        {
            return $"{this._date} / ({this._state.Substring(0, 9)})...";
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }
}
