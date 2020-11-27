using System;

namespace Memento.Solution_3
{
    /// <summary>
    /// the object that we want to save and restore, such as a check point in an application
    /// </summary>
    public class Originator<T>
    {
        private T state;
        //for saving the state
        public Memento<T> CreateMemento()
        {
            Memento<T> m = new Memento<T>();
            m.SetState(state);
            return m;
        }
        //for restoring the state
        public void SetMemento(Memento<T> m)
        {
            state = m.GetState();
        }
        //change the state of the Originator
        public void SetState(T state)
        {
            this.state = state;
        }
        //show the state of the Originator
        public void ShowState()
        {
            Console.WriteLine(state.ToString());
        }
    }
}
