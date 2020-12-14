using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class President : Employee
    {
        public President()
          : base("Dick", 45000.0, 21)
        {
        }
    }
}
