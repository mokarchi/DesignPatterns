using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class Clerk : Employee
    {
        public Clerk()
          : base("Hank", 25000.0, 14)
        {
        }
    }
}
