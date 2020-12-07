using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator.FirstSolution
{
    interface AbstractIterator
    {
        Elempoyee First();
        Elempoyee Next();
        bool IsCompleted { get; }
    }
}
