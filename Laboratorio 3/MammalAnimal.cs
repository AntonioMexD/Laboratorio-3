using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
    public class MammalAnimal:IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public float Weight { get; set; }
        public string Type { get; set; }
        public MammalAnimal()
        {
            Type = "Mammals";
        }
        public void ShowAttribute()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Type: " + Type);
        }
        public void SetAttribute()
        {
            Console.WriteLine("Ingrese nombre: ");
            Name = Console.ReadLine();
            Console.WriteLine("Ingrese color: ");
            Color = Console.ReadLine();
            Console.WriteLine("Ingrese peso: ");
            Weight = Convert.ToInt32(Console.ReadLine());
        }
    }
}
