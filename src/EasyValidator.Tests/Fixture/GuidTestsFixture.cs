using Bogus;
using EasyValidator.Tests.Entity;
using System;
using System.Collections.Generic;
using Xunit;

namespace EasyValidator.Tests.Fixture
{
    [CollectionDefinition(nameof(GuidCollection))]
    public class GuidCollection : ICollectionFixture<GuidTestsFixture>
    {

    }
    public class GuidTestsFixture : IDisposable
    {
        public List<Sample> GenerateListGuidValid(int quantity)
        {
            var samples = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                samples.Add(new Sample { Guid = faker.Random.Guid().ToString() });
            }

            return samples;
        }

        public List<Sample> GenerateListGuidInvalid(int quantity)
        {
            var samples = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                samples.Add(new Sample { Guid = faker.Random.String() });
            }

            return samples;
        }
        public void Dispose()
        {
            
        }
    }
}
