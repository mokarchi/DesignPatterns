using Decorator.Book;
using Decorator.Restaurant;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create book
            //Decorator.Book.Book book = new Decorator.Book.Book("Worley", "Inside ASP.NET", 10);
            //book.Display();

            //// Create video
            //Video video = new Video("Spielberg", "Jaws", 23, 92);
            //video.Display();
            //// Make video borrowable, then borrow and display
            //Console.WriteLine("\nMaking video borrowable:");
            //Borrowable borrowvideo = new Borrowable(video);
            //borrowvideo.BorrowItem("Customer #1");
            //borrowvideo.BorrowItem("Customer #2");
            //borrowvideo.Display();


            //Step 1: Define some dishes, and how many of each we can make
            FreshSalad caesarSalad = new FreshSalad("Crisp romaine lettuce", "Freshly-grated Parmesan cheese", "House-made Caesar dressing");
            caesarSalad.Display();

            Pasta fettuccineAlfredo = new Pasta("Fresh-made daily pasta", "Creamly garlic alfredo sauce");
            fettuccineAlfredo.Display();

            Console.WriteLine("\nMaking these dishes available.");

            //Step 2: Decorate the dishes; now if we attempt to order them once we're out of ingredients, we can notify the customer
            Available caesarAvailable = new Available(caesarSalad, 3);
            Available alfredoAvailable = new Available(fettuccineAlfredo, 4);

            //Step 3: Order a bunch of dishes
            caesarAvailable.OrderItem("John");
            caesarAvailable.OrderItem("Sally");
            caesarAvailable.OrderItem("Manush");

            alfredoAvailable.OrderItem("Sally");
            alfredoAvailable.OrderItem("Francis");
            alfredoAvailable.OrderItem("Venkat");
            alfredoAvailable.OrderItem("Diana");
            alfredoAvailable.OrderItem("Dennis"); //There won't be enough for this order.

            caesarAvailable.Display();
            alfredoAvailable.Display();

        }
    }
}
