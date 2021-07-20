using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Concrete Factory
    class LandAnimalFactory : AnimalFactory
    {
        public override Animal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Dog"))
            {
                return new Dog();
            }
            else if (AnimalType.Equals("Cat"))
            {
                return new Cat();
            }
            else if (AnimalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null;
        }
    }
}
