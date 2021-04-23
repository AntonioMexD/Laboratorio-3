using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
    public class LazySingletonAnimal
    {
        private static LazySingletonAnimal _instance = null;
        private IList<IAnimal> Animals = new List<IAnimal>();
        private LazySingletonAnimal() { }
        public static LazySingletonAnimal Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LazySingletonAnimal();
                return _instance;
            }
        }
        public void InsertAnimal(IAnimal animal)
        {
            Animals.Add(animal);
        }
        public void ShowListAnimals()
        {
            Console.WriteLine("---ANIMALS---");
            foreach(IAnimal animal in Animals)
            {
                animal.ShowAttribute();
                Console.WriteLine("");
            }
        }
        public IAnimal FindAnimal(string name)
        {
            foreach (IAnimal animal in Animals)
            {
                if (animal.Name == name)
                {
                    return animal;
                }
            }
            return null;
        }
    }
}
