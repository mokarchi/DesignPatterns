using System.Collections.Generic;

namespace Memento.Solution_2
{
    public class Caretaker
    {
        List<Memento> savedArticles = new List<Memento>();
        public void addMemento(Memento m)
        {
            savedArticles.Add(m);
        }
        public Memento getMemento(int index)
        {
            return savedArticles[index];
        }
    }
}
