using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string Animal);
    }
}
