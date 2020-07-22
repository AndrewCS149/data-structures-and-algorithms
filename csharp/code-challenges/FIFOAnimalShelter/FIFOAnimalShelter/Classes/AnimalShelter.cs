using System;
using System.Collections.Generic;
using System.Text;

namespace FIFOAnimalShelter.Classes
{
    public class AnimalShelter
    {
        private Queue<Animal> Shelter { get; set; }

        public AnimalShelter()
        {
            Shelter = new Queue<Animal>();
        }

        /// <summary>
        /// Adds an animal (Dog or Cat) to the shelter
        /// </summary>
        /// <param name="type">Dog or Cat to add to shelter</param>
        public void Enqueue(Animal type)
        {
            Shelter.Enqueue(type);
        }


        public Animal Dequeue()
        {
            return Shelter.Dequeue();
        }

        /// <summary>
        /// Returns the value at the front of the queue 
        /// </summary>
        /// <returns>Returns Dog or Cat at front of queue</returns>
        public Animal Peek()
        {
            return Shelter.Peek();
        }
    }
}
