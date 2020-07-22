using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Dog : Animal
    {
        public string Type { get; set; }

        public Dog(string type)
        {
            Type = type;
        }
    }
}
