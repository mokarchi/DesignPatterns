using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Solution1
            //Memento memento = new Memento();
            // Create an originator, which will hold our state data.
            //ConcreteOriginator myOriginator = new ConcreteOriginator("Hello World!", StateType.ONE);
            //ConcreteOriginator anotherOriginator = new ConcreteOriginator("Hola!", StateType.ONE);
            //ConcreteOriginator2 thirdOriginator = new ConcreteOriginator2(7);
            //anotherOriginator.Speak();
            //thirdOriginator.Speak();
            // Set some state data.
            //myOriginator.Speak();
            // Save the states into our memento.
            //myOriginator.SaveMemento(memento);
            //anotherOriginator.SaveMemento(memento);
            //thirdOriginator.SaveMemento(memento);
            // Now change our originators' states.
            //myOriginator.SetData("Goodbye!", StateType.TWO);
            //anotherOriginator.SetData("Adios!", StateType.TWO);
            //thirdOriginator.SetData(99);
            //myOriginator.Speak();
            //anotherOriginator.Speak();
            //thirdOriginator.Speak();
            // Restore our originator's state.
            //myOriginator.RestoreMemento(memento);
            //anotherOriginator.RestoreMemento(memento);
            //thirdOriginator.RestoreMemento(memento);
            //myOriginator.Speak();
            //anotherOriginator.Speak();
            //thirdOriginator.Speak();
            //Console.ReadKey();
            #endregion

            #region Solution3
            //Originator<string> orig = new Originator<string>();
            //orig.SetState("state0");
            //Caretaker<string>.SaveState(orig); //save state of the originator
            //orig.ShowState();
            //orig.SetState("state1");
            //Caretaker<string>.SaveState(orig); //save state of the originator
            //orig.ShowState();
            //orig.SetState("state2");
            //Caretaker<string>.SaveState(orig); //save state of the originator
            //orig.ShowState();
            ////restore state of the originator
            //Caretaker<string>.RestoreState(orig, 1);
            //orig.ShowState();  //shows state0
            #endregion

            #region Solution4
            //Originator o = new Originator();
            //o.State = "On";
            //// Store internal state
            //Caretaker c = new Caretaker();
            //c.Memento = o.CreateMemento();
            //// Continue changing originator
            //o.State = "Off";
            //// Restore saved state
            //o.SetMemento(c.Memento);
            //// Wait for user
            //Console.ReadKey();
            #endregion

            #region Real World with Solution 4
            //SalesProspect s = new SalesProspect();
            //s.Name = "Noel van Halen";
            //s.Phone = "(412) 256-0990";
            //s.Budget = 25000.0;
            //// Store internal state
            //ProspectMemory m = new ProspectMemory();
            //m.Memento = s.SaveMemento();
            //// Continue changing originator
            //s.Name = "Leo Welch";
            //s.Phone = "(310) 209-7111";
            //s.Budget = 1000000.0;
            //// Restore saved state
            //s.RestoreMemento(m.Memento);
            //// Wait for user
            //Console.ReadKey();
            #endregion

            #region Book
            // Initialise book
            //var book = new Book
            //{
            //    ISBN = "0450488357",
            //    Title = "The Tommyknockers",
            //    Author = "Stephen King"
            //};
            //book.ShowBook();
            //System.Threading.Thread.Sleep(2000);

            //// Set undo point
            //Caretaker history = new Caretaker();
            //history.Memento = book.CreateUndo();

            //// Modify book
            //book.ISBN = "0330376144";
            //book.Title = "The Rats";
            //book.Author = "James Herbert";
            //book.ShowBook();

            //// Undo
            //book.RestoreFromUndo(history.Memento);
            //book.ShowBook();
            #endregion

            #region Solution5
            //Caretaker caretaker = new Caretaker();
            //Originator originator = new Originator();
            //originator.setState("State1");
            //originator.setState("State2");
            //caretaker.addMemento(originator.save());
            //originator.setState("State3");
            //caretaker.addMemento(originator.save());
            //originator.setState("State4");
            //originator.restore(caretaker.getMemento(1)); 
            //Console.ReadLine();
            #endregion

            #region Car
            //Caretaker caretaker = new Caretaker();
            //Mechanics mechanic = new Mechanics();
            //mechanic.setState("The brake drum is in use. Begin of work");
            //caretaker.addMemento(mechanic.save());
            //mechanic.setState("The brake drum is available to use. End of work");
            //mechanic.restore(caretaker.getMemento(0));
            #endregion

            #region Solution6
            // Client code.
            //Originator originator = new Originator("Super-duper-super-puper-super.");
            //Caretaker caretaker = new Caretaker(originator);

            //caretaker.Backup();
            //originator.DoSomething();

            //caretaker.Backup();
            //originator.DoSomething();

            //caretaker.Backup();
            //originator.DoSomething();

            //Console.WriteLine();
            //caretaker.ShowHistory();

            //Console.WriteLine("\nClient: Now, let's rollback!\n");
            //caretaker.Undo();

            //Console.WriteLine("\n\nClient: Once more!\n");
            //caretaker.Undo();

            //Console.WriteLine();
            #endregion

            #region Restaurant
            //Here's a new supplier for our restaurant
            //FoodSupplier s = new FoodSupplier();
            //s.Name = "Harold Karstark";
            //s.Phone = "(482) 555-1172";

            //// Let's store that entry in our database.
            //SupplierMemory m = new SupplierMemory();
            //m.Memento = s.SaveMemento();

            //// Continue changing originator
            //s.Address = "548 S Main St. Nowhere, KS";

            //// Crap, gotta undo that entry, I entered the wrong address
            //s.RestoreMemento(m.Memento);
            #endregion
        }
    }
}
