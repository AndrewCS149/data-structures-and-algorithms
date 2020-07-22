using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Cat : Animal
    {
        public string Type { get; set; }

        public Cat(string type)
        {
            Type = type;
        }
    }
}
