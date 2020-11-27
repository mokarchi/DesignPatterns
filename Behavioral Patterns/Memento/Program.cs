using Memento.Real_world_with_Solution_4;
using Memento.Solution_3;
using Memento.Solution_4;
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
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;
            // Store internal state
            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();
            // Continue changing originator
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;
            // Restore saved state
            s.RestoreMemento(m.Memento);
            // Wait for user
            Console.ReadKey();
            #endregion
        }
    }
}
