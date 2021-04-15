using Bogus;
using EasyValidator.Tests.Entity;
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
        public List<Sample> GenerateListPhoneValid(int quantity)
        {
            var samples = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                samples.Add(new Sample { Phone = faker.Person.Phone });
            }

            return samples;
        }

        public List<Sample> GenerateListPhoneInvalid(int quantity)
        {
            var samples = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                samples.Add(new Sample { Phone = faker.Random.String() });
            }

            return samples;
        }
        public void Dispose()
        {
            
        }
    }
}
