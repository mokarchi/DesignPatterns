using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.FirstSolution
{
    interface AbstractCollection
    {
        Iterator CreateIterator();
    }
}
