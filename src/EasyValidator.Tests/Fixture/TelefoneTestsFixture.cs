using Bogus;
using System;
using System.Collections.Generic;
using Xunit;

namespace EasyValidator.Tests.Fixture
{
    [CollectionDefinition(nameof(TelefoneCollection))]
    public class TelefoneCollection : ICollectionFixture<TelefoneTestsFixture>
    {

    }
    public class TelefoneTestsFixture : IDisposable
    {
        public List<string> GenerateListPhoneValid(int quantity)
        {
            var phones = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                phones.Add(faker.Person.Phone);
            }

            return phones;
        }

        public List<string> GenerateListPhoneInvalid(int quantity)
        {
            var phones = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                phones.Add(faker.Random.String());
            }

            return phones;
        }
        public void Dispose()
        {
            
        }
    }
}
