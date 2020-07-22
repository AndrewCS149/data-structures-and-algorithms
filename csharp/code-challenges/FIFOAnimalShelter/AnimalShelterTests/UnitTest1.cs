using System;
using Xunit;
using FIFOAnimalShelter.Classes;

namespace AnimalShelterTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanEnqueueAndDequeueADogToTheShelter()
        {
            // arrange
            AnimalShelter shelter = new AnimalShelter();
            Dog dog = new Dog("Dog");
            
            shelter.Enqueue(dog);

            // act
            var shelterString = shelter.Dequeue();
            //shelter.Shelter.
            // assert
            Assert.Equal(dog, shelterString);
        }

        [Fact]
        public void CanEnqueueAndDequeueACatToTheShelter()
        {
            // arrange
            AnimalShelter shelter = new AnimalShelter();
            Cat cat = new Cat("Cat");

            shelter.Enqueue(cat);

            // act
            var shelterString = shelter.Dequeue();

            // assert
            Assert.Equal(cat, shelterString);
        }
    }
}
