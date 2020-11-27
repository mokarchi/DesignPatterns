namespace Memento.Solution_2
{
    public class Memento
    {
        private string article;
        public Memento(string articleSaved)
        {
            article = articleSaved;
        }
        public string getSavedArticle()
        {
            return article;
        }
    }
}
