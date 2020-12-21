using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    abstract class VehicleBuilder
    {
        protected Vehicle vehicle;
        public Vehicle Vehicle
        {
            get { return vehicle; }
        }

        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
