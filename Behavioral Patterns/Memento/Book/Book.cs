using System;
using System.Collections.Generic;
using System.Text;

namespace MementoBook
{
    public class Book
    {
        private string _isbn;
        private string _title;
        private string _author;
        private DateTime _lastEdited;

        public string ISBN
        {
            get { return _isbn; }
            set
            {
                _isbn = value;
                SetLastEdited();
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                SetLastEdited();
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                _author = value;
                SetLastEdited();
            }
        }

        public Book()
        {
            SetLastEdited();
        }

        private void SetLastEdited()
        {
            _lastEdited = DateTime.UtcNow;
        }

        public Memento CreateUndo()
        {
            return new Memento(_isbn, _title, _author, _lastEdited);
        }

        public void RestoreFromUndo(Memento memento)
        {
            _title = memento.Title;
            _author = memento.Author;
            _isbn = memento.ISBN;
            _lastEdited = memento.LastEdited;
        }

        public void ShowBook()
        {
            Console.WriteLine(
                "{0} - '{1}' by {2}, edited {3}.", ISBN, Title, Author, _lastEdited);
        }
    }
}
