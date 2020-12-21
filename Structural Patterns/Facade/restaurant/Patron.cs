using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.restaurant
{
    /// <summary>
    /// Patron of the restaurant (duh!)
    /// </summary>
    class Patron
    {
        private string _name;

        public Patron(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }

}
