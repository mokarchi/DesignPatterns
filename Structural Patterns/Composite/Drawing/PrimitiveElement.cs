﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Drawing
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name)
          : base(name)
        {
        }

        public override void Add(DrawingElement c)
        {
            Console.WriteLine("Cannot add to a PrimitiveElement");
        }

        public override void Remove(DrawingElement c)
        {
            Console.WriteLine("Cannot remove from a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + " " + _name);
        }
    }
}
