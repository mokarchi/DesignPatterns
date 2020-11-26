using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    class Memento
    {
        private Dictionary<Guid, object> stateList = new Dictionary<Guid, object>();
        public object GetState(Guid key)
        {
            return stateList[key];
        }
        public void SetState(Guid key, object newState)
        {
            stateList[key] = newState;
        }
        public Memento()
        {
        }
    }
}
