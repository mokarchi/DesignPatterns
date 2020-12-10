using System;
using Strategy.Sorting;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new SortedList();
            context.SetSortStrategy(new QuickSort());
            context.Sort();
        }
    }
}
