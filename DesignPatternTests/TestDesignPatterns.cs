using Models;
using Singleton;

namespace DesignPatternTests
{
    public class TestDesignPatterns
    {
        [Fact]
        public void AddNListEmployessGenericSingletonTest()
        {
            foreach (var i in Enumerable.Range(0, 10))
            {
                EmployeeSingleton.Instance.Add(new Employee()
                {
                    Id = Guid.NewGuid(),
                    Email = Faker.Internet.Email(),
                    Firstname = Faker.Name.First(),
                    Lastname = Faker.Name.Last(),
                });
            }
            var crudFakeDb = EmployeeSingleton.Instance.List();
            Assert.True(crudFakeDb.Any());
        }
    }
}