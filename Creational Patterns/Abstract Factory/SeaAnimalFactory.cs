using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Concrete Factory
    class SeaAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Shark"))
            {
                return new Shark();
            }
            else if (AnimalType.Equals("Octopus"))
            {
                return new Octopus();
            }
            else
                return null;
        }
    }
}
