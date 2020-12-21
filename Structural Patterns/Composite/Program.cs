using System;
using Composite.Drawing;
using Composite.Drink;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a tree structure 
            //CompositeElement root = new CompositeElement("Picture");
            //root.Add(new PrimitiveElement("Red Line"));
            //root.Add(new PrimitiveElement("Blue Circle"));
            //root.Add(new PrimitiveElement("Green Box"));

            //// Create a branch
            //CompositeElement comp = new CompositeElement("Two Circles");
            //comp.Add(new PrimitiveElement("Black Circle"));
            //comp.Add(new PrimitiveElement("White Circle"));
            //root.Add(comp);

            //// Add and remove a PrimitiveElement
            //PrimitiveElement pe = new PrimitiveElement("Yellow Line");
            //root.Add(pe);
            //root.Remove(pe);

            //// Recursively display nodes
            //root.Display(1);

            var colas = new Cola(210);
            colas.Flavors.Add(new VanillaCola(215));
            colas.Flavors.Add(new CherryCola(210));

            var lemonLime = new LemonLime(185);

            var rootBeers = new RootBeer(195);
            rootBeers.Flavors.Add(new VanillaRootBeer(200));
            rootBeers.Flavors.Add(new StrawberryRootBeer(200));

            SodaWater sodaWater = new SodaWater(180);
            sodaWater.Flavors.Add(colas);
            sodaWater.Flavors.Add(lemonLime);
            sodaWater.Flavors.Add(rootBeers);

            sodaWater.DisplayCalories();
        }
    }
}
