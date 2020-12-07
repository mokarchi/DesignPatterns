using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.FirstSolution
{
    class ConcreteCollection : AbstractCollection
    {
        private List<Elempoyee> listEmployees = new List<Elempoyee>();
        //Create Iterator
        public IteratorPattern CreateIterator()
        {
            return new IteratorPattern(this);
        }
        // Gets item count
        public int Count
        {
            get { return listEmployees.Count; }
        }
        //Add items to the collection
        public void AddEmployee(Elempoyee employee)
        {
            listEmployees.Add(employee);
        }
        //Get item from collection
        public Elempoyee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }
}
