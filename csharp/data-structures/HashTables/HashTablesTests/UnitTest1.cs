using HashTables;
using System;
using Xunit;

//using static HashTables.Hasht;
namespace HashTablesTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddValuesToHashtable()
        {
            // arrange
            Hasht hTable = new Hasht(4);
            hTable.Add("person1", "Andrew");
            hTable.Add("person2", "Courtney");
            hTable.Add("person3", "Hank");
            hTable.Add("person4", "Bob");

            // act
            int count = hTable.Count();

            // assert
            Assert.NotNull(hTable);
            Assert.Equal(4, count);
        }

        [Fact]
        public void CanReturnTrueIfDoesNotContainValue()
        {
            // arrange
            Hasht hTable = new Hasht(4);
            hTable.Add("person1", "Andrew");
            hTable.Add("person2", "Courtney");

            // act
            bool contains = hTable.Contains("person2");

            // assert
            Assert.True(contains);
        }

        [Fact]
        public void CanReturnFalseIfDoesNotContainValue()
        {
            // arrange
            Hasht hTable = new Hasht(4);
            hTable.Add("person1", "Andrew");
            hTable.Add("person2", "Courtney");

            // act
            bool contains = hTable.Contains("person3");

            // assert
            Assert.False(contains);
        }

        [Fact]
        public void CanGetValueFromTable()
        {
            // arrange
            Hasht hTable = new Hasht(4);
            hTable.Add("person1", "Andrew");
            hTable.Add("person2", "Courtney");

            // act
            string value = hTable.GetValue("person2");

            // assert
            Assert.Equal("Courtney", value);
        }

        [Fact]
        public void CanReturnNullIfKeyNotFound()
        {
            // arrange
            Hasht hTable = new Hasht(4);
            hTable.Add("person1", "Andrew");
            hTable.Add("person2", "Courtney");

            // act
            var value = hTable.GetValue("person3");

            // assert
            Assert.Null(value);
        }

        [Fact]
        public void CanHandleCollisions()
        {
            // arrange
            Hasht hTable = new Hasht(4);
            hTable.Add("person1", "Andrew");
            hTable.Add("person2", "Courtney");
            hTable.Add("2person", "bob");

            // act
            var value = hTable.GetValue("person2");

            // assert
            Assert.NotNull(hTable);
            Assert.NotNull(value);
            Assert.Equal("Courtney", value);
        }

        [Fact]
        public void CanRetrieveValueFromBucketWithinHashtable()
        {
            // arrange
            Hasht hTable = new Hasht(4);
            hTable.Add("person1", "Andrew");
            hTable.Add("person2", "Courtney");
            hTable.Add("2person", "bob");
            hTable.Add("2person", "joe");

            // act
            var value = hTable.GetValue("2person");

            // assert
            Assert.NotNull(value);
            Assert.Equal("Courtney", value);
        }
    }
}