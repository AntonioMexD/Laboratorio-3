using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
    public class ConcreteAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string Animal)
        {
            switch(Animal)
            {
                case "Mammal":
                    return new MammalAnimal();
                case "Fish":
                    return new FishAnimal();
                case "Bird":
                    return new BirdAnimal();
                case "Reptile":
                    return new ReptileAnimal();
                default:
                    throw new Exception(string.Format("Animal '{0} cannot be created", Animal));
            }
        }
    }
}
