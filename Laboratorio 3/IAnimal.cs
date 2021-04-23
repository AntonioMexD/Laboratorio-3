using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_3
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Color { get; set; }
        float Weight { get; set; }
        string Type { get; set; }
        void ShowAttribute();
        void SetAttribute();

    }
}
