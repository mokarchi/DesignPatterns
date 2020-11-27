namespace Memento.Solution_3
{
    /// <summary>
    /// //object that stores the historical state
    /// </summary>
    public class Memento<T>
    {
        private T state;
        public T GetState()
        {
            return state;
        }
        public void SetState(T state)
        {
            this.state = state;
        }
    }
}
