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
            Dog dog = new Dog("Loki");
            
            shelter.Enqueue(dog);

            // act
            Animal animal = new Animal();
            var shelterString = shelter.Dequeue(animal);

            // assert
            Assert.Equal(dog, shelterString);
        }

        [Fact]
        public void CanEnqueueAndDequeueACatToTheShelter()
        {
            // arrange
            AnimalShelter shelter = new AnimalShelter();
            Cat cat = new Cat("Mittens");

            shelter.Enqueue(cat);

            // act
            Animal animal = new Animal();
            var shelterString = shelter.Dequeue(animal);

            // assert
            Assert.Equal(cat, shelterString);
        }

        [Fact]
        public void CanPeekValueAndReturnIt()
        {
            // arrange 
            AnimalShelter shelter = new AnimalShelter();
            Dog dog = new Dog("Loki");

            shelter.Enqueue(dog);

            // act
            var peekResult = shelter.Peek();

            // assert
            Assert.Equal(dog, peekResult);
        }
    }
}
