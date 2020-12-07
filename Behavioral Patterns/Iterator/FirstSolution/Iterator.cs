using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.FirstSolution
{
    class Iterator : AbstractIterator
    {
        private ConcreteCollection collection;
        private int current = 0;
        private int step = 1;
        // Constructor
        public Iterator(ConcreteCollection collection)
        {
            this.collection = collection;
        }
        // Check whether iteration is complete
        public bool IsCompleted
        {
            get { return current >= collection.Count; }
        }

        public Elempoyee First()
        {
            current = 0;
            return collection.GetEmployee(current);
        }

        public Elempoyee Next()
        {
            current += step;
            if (!IsCompleted)
            {
                return collection.GetEmployee(current);
            }
            else
            {
                return null;
            }
        }
    }
}
