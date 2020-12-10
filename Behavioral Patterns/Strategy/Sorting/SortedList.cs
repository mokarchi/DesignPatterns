using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Sorting
{
    class SortedList
    {
        private ArrayList list = new ArrayList();
        private SortStrategy sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this.sortstrategy = sortstrategy;
        }
        public void Add(string name)
        {
            list.Add(name);
        }
        public void Sort()
        {
            sortstrategy.Sort(list);
        }
    }
}
