using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Real_world_with_Solution_4
{
    /// <summary>
    /// The 'Memento' class
    /// </summary>
    public class Memento
    {
        private string _name;
        private string _phone;
        private double _budget;

        public Memento(string name, string phone, double budget)
        {
            this._name = name;
            this._phone = phone;
            this._budget = budget;
        }

        // Gets or sets name
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Gets or set phone
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        // Gets or sets budget
        public double Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }
    }
}
