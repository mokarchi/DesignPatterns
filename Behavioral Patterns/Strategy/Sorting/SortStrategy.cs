using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Sorting
{
    abstract class SortStrategy
    {
        public abstract void Sort(ArrayList list);
    }
}
