using Xunit;
using System;
using System.Collections.Generic;
using System.Data;
using Lb2;

namespace Lb2.Tests
{
    public class PeopleProxyTests
    {
        private Person CreateTestPerson()
        {
            return new Person
            {
                name = "Test",
                surname = "User",
                Gender = "Male",
                Year_of_birth = 1990,
                City = "TestCity",
                Country = "TestCountry",
                Height = 180.5
            };
        }

        private static void Dispose()
        {
            PeopleProxy.GetPeople().Clear(); // Очистка статического объекта
        }

        [Fact]
        public void Add_CorrectAdd_CorrectAddToProxy()
        {
            Dispose();

            // Arrange
            var proxy = new PeopleProxy();
            var person = CreateTestPerson();

            // Act
            proxy.Add(person);

            // Assert
            var foundPerson = proxy.Find(0);
            Assert.NotNull(foundPerson);
            Assert.Equal(person.name, foundPerson.name);
            Assert.Equal(person.surname, foundPerson.surname);
        }

        [Fact]
        public void Remove_CorrectRemove_CorrectAddToProxy()
        {
            Dispose();

            // Arrange
            var proxy = new PeopleProxy();
            var person1 = CreateTestPerson();
            var person2 = CreateTestPerson();
            person2.name = "Test2";

            proxy.Add(person1);
            proxy.Add(person2);

            // Act
            proxy.Remove(0); // Remove the first person

            // Assert
            var remainingPerson = proxy.Find(0);
            Assert.NotNull(remainingPerson);
            Assert.Equal("Test", remainingPerson.name);
        }

        [Fact]
        public void Add_CorrectAddAndUploadDataToPeople_CorrectAddToPeople()
        {
            Dispose();

            // Arrange
            var proxy = new PeopleProxy();
            var person = CreateTestPerson();

            // Act
            proxy.Add(person);
            proxy.uploadChanges();

            // Assert
            var peopleStack = PeopleProxy.GetPeople().getStack();
            Assert.Contains(person, peopleStack);
        }

        [Fact]
        public void Remove_CorrectRemoveAndUploadDataToPeople_CorrectAddToPeople()
        {
            Dispose();

            // Arrange
            var proxy = new PeopleProxy();
            var person1 = CreateTestPerson();
            var person2 = CreateTestPerson();
            person2.name = "Test2";

            proxy.Add(person1);
            proxy.Add(person2);
            proxy.uploadChanges();

            // Act
            proxy.Remove(0);
            proxy.uploadChanges();

            // Assert
            var peopleStack = PeopleProxy.GetPeople().getStack();
            Assert.DoesNotContain(person2, peopleStack);
            Assert.Contains(person1, peopleStack);
        }

        [Fact]
        public void DefaultConstructor_Create_CorrectDownloadDataFromPeople()
        {
            Dispose();

            // Arrange
            var people = PeopleProxy.GetPeople();
            people.Clear();
            var person = CreateTestPerson();
            people.Add(person);

            // Act
            var proxy = new PeopleProxy();

            // Assert
            var foundPerson = proxy.Find(0);
            Assert.NotNull(foundPerson);
            Assert.Equal(person.name, foundPerson.name);
            Assert.Equal(person.surname, foundPerson.surname);
        }

        [Fact]
        public void _DemonstrationOfTwoProxiesWorking_CorrectInteraction()
        {
            Dispose();

            // Arrange
            var people = PeopleProxy.GetPeople();
            people.Clear();

            var proxy1 = new PeopleProxy();
            var proxy2 = new PeopleProxy();

            var person1 = CreateTestPerson();
            var person2 = CreateTestPerson();
            person2.name = "Test2";

            // Act
            proxy1.Add(person1);
            proxy1.Add(person2);

            proxy1.uploadChanges();
            proxy2.downloadChanges();

            // Assert
            // Both proxies should now have both persons
            Assert.Equal(2, proxy1.GenerateData().Rows.Count);
            Assert.Equal(2, proxy2.GenerateData().Rows.Count);

            // People should have both persons
            Assert.Equal(2, people.getStack().Count);
        }
    }
}

//namespace Lb2.Tests
//{
//    using Xunit;
//    public class PeopleProxyTests
//    {
//        [Fact]
//        public void Add_CorrectAdd_CorrectAddToProxy()
//        {

//        }

//        [Fact]
//        public void Remove_CorrectRemove_CorrectAddToProxy()
//        {

//        }

//        [Fact]
//        public void Add_CorrectAddAndUploadDataToPeople_CorrectAddToPeople()
//        {

//        }

//        [Fact]
//        public void Remove_CorrectRemoveAndUploadDataToPeople_CorrectAddToPeople()
//        {

//        }

//        [Fact]
//        public void DefaultConstructor_Create_CorrectDownloadDataFromPeople()
//        {

//        }

//        [Fact]
//        public void _DemonstrationOfTwoProxiesWorking_CorrectInteraction()
//        {

//        }
//    }
//}
