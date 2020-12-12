using Command.eshop;
using Command.restaurant;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            #region restaurant
            //Patron patron = new Patron();
            //patron.SetCommand(1 /*Add*/);
            //patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            //patron.ExecuteCommand();

            //patron.SetCommand(1 /*Add*/);
            //patron.SetMenuItem(new MenuItem("Hamburger", 2, 2.59));
            //patron.ExecuteCommand();

            //patron.SetCommand(1 /*Add*/);
            //patron.SetMenuItem(new MenuItem("Drink", 2, 1.19));
            //patron.ExecuteCommand();

            //patron.ShowCurrentOrder();

            ////Remove the french fries
            //patron.SetCommand(3 /*Remove*/);
            //patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            //patron.ExecuteCommand();

            //patron.ShowCurrentOrder();

            ////Now we want 4 hamburgers rather than 2
            //patron.SetCommand(2 /*Edit*/);
            //patron.SetMenuItem(new MenuItem("Hamburger", 4, 2.59));
            //patron.ExecuteCommand();

            //patron.ShowCurrentOrder();

            //Console.ReadKey();
            #endregion

            var modifyPrice = new ModifyPrice();
            var product = new Product("Phone", 500);
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 100));

            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Increase, 50));
            Execute(product, modifyPrice, new ProductCommand(product, PriceAction.Decrease, 2500));
            Console.WriteLine(product);
            Console.WriteLine();
            modifyPrice.UndoActions();
            Console.WriteLine(product);
        }

        private static void Execute(Product product, ModifyPrice modifyPrice, ICommand productCommand)
        {
            modifyPrice.SetCommand(productCommand);
            modifyPrice.Invoke();
        }
    }
}
