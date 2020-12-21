using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.cook
{
    /// <summary>
    /// The new Meat class, which represents 
    /// details about a particular kind of meat.
    /// </summary>
    class Meat
    {
        protected string MeatName;
        protected float SafeCookTempFahrenheit;
        protected float SafeCookTempCelsius;
        protected double CaloriesPerOunce;
        protected double ProteinPerOunce;

        // Constructor
        public Meat(string meat)
        {
            this.MeatName = meat;
        }

        public virtual void LoadData()
        {
            Console.WriteLine("\nMeat: {0} ------ ", MeatName);
        }
    }
}
