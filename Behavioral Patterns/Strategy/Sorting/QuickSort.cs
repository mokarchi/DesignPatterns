using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Sorting
{
    class QuickSort : SortStrategy
    {
        public override void Sort(ArrayList list)
        {
            Console.WriteLine("QuickSort");
        }
    }
}
