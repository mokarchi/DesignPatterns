using Decorator.Book;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create book
            Decorator.Book.Book book = new Decorator.Book.Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();
            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");
            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");
            borrowvideo.Display();
        }
    }
}
