using Models;
using Singleton;

namespace DesignPatternTests
{
    public class TestDesignPatterns
    {

        private readonly GenericSingleton<Employee> _genericSingleton;

        [Fact]
        public void AddNListEmployessGenericSingletonTest()
        {
            foreach (var i in Enumerable.Range(0, 10))
            {
                _genericSingleton.GetInstance().Add(new Employee()
                {
                    Id = Guid.NewGuid(),
                    Email = Faker.Internet.Email(),
                    Firstname = Faker.Name.First(),
                    Lastname = Faker.Name.Last(),
                });
            }
            var crudFakeDb = _genericSingleton.GetInstance().List();
            Assert.True(crudFakeDb.Any());
        }
    }
}