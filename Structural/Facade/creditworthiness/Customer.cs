using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.creditworthiness
{
    /// <summary>
    /// Customer class
    /// </summary>
    class Customer
    {
        private string _name;
        public Customer(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
