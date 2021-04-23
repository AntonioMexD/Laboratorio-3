using System;

namespace Laboratorio_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            AnimalFactory animalFactory = new ConcreteAnimalFactory();
            IAnimal Reptile = animalFactory.GetAnimal("Reptile");
            IAnimal Fish = animalFactory.GetAnimal("Fish");
            IAnimal Bird = animalFactory.GetAnimal("Bird");
            IAnimal Mammal = animalFactory.GetAnimal("Mammal");

            int Option;
            string NameAnimal;
            do
            {
                Console.WriteLine("-----Menu-----");
                Console.WriteLine("1.- Insert Reptile");
                Console.WriteLine("2.- Insert Fish");
                Console.WriteLine("3.- Insert Bird");
                Console.WriteLine("4.- Insert Mammal");
                Console.WriteLine("5.- Show Animals");
                Console.WriteLine("6.- Find Animal");
                Option = Convert.ToInt16(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        Reptile.SetAttribute();
                        LazySingletonAnimal.Instance.InsertAnimal(Reptile);
                        break;
                    case 2:
                        Fish.SetAttribute();
                        LazySingletonAnimal.Instance.InsertAnimal(Fish);
                        break;
                    case 3:
                        Bird.SetAttribute();
                        LazySingletonAnimal.Instance.InsertAnimal(Bird);
                        break;
                    case 4:
                        Mammal.SetAttribute();
                        LazySingletonAnimal.Instance.InsertAnimal(Mammal);
                        break;
                    case 5:
                        LazySingletonAnimal.Instance.ShowListAnimals();
                        break;
                    case 6:
                        Console.WriteLine("Enter the name of the animal to find");
                        NameAnimal = Console.ReadLine();
                        LazySingletonAnimal.Instance.FindAnimal(NameAnimal).ShowAttribute();
                        break;
                    default:
                        break;
                }
            } while (Option != 0);
        }
    }
}
