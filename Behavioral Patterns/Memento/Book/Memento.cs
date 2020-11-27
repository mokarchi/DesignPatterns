using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    public class Memento
    {
        public string ISBN { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public DateTime LastEdited { get; private set; }

        public Memento(string isbn, string title, string author, DateTime lastEdited)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            LastEdited = lastEdited;
        }
    }
}
