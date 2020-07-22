using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class Cat : Animal
    {
        public Cat(string name)
        {
            Type = "Cat";
            Name = name;
        }
    }
}
