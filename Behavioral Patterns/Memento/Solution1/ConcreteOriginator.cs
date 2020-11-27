using System;

namespace Memento.Solution_1
{
    class ConcreteOriginator : MementoBase
    {
        private int value = 0;
        public ConcreteOriginator(int newValue)
        {
            SetData(newValue);
        }
        public void SetData(int newValue)
        {
            value = newValue;
        }
        public void Speak()
        {
            Console.WriteLine("My value is " + value.ToString());
        }

        public override void RestoreMemento(Memento memento)
        {
            memento.SetState(mementoKey, value);
        }

        public override void SaveMemento(Memento memento)
        {
            int restoredValue = (int)memento.GetState(mementoKey);
            SetData(restoredValue);
        }
    }
}
