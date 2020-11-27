using System;

namespace Memento.Solution_2
{
    public class Originator
    {
        private string article;
        public void set(string newArticle)
        {
            var message = String.Format("From Originator: Current Version of Article {0}", newArticle);
            article = newArticle;
        }
        public Memento storeInMemento()
        {
            var message = String.Format("From Originator: Saving to Memento");
            return new Memento(article);
        }
        public string restoreFromMemento(Memento memento)
        {
            article = memento.getSavedArticle();
            var message = String.Format("From Originator: Previous Article Saved in Memento");
            return article;
        }
    }
}
