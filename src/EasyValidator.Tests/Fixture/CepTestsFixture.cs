using Bogus;
using System;
using System.Collections.Generic;
using Xunit;

namespace EasyValidator.Tests.Fixture
{
    [CollectionDefinition(nameof(CepCollection))]
    public class CepCollection : ICollectionFixture<CepTestsFixture>
    {

    }
    public class CepTestsFixture : IDisposable
    {
        public void Dispose()
        {
            
        }

        public List<string> GenerateListCepValid(int quantity)
        {
            var phones = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");
                
                phones.Add(faker.Person.Address.ZipCode);
            }

            return phones;
        }

        public List<string> GenerateListCepInvalid(int quantity)
        {
            var phones = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                phones.Add(faker.Random.Int().ToString());
            }

            return phones;
        }
    }
}
