using Bogus;
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
        public List<string> GenerateListGuidValid(int quantity)
        {
            var guids = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                guids.Add(faker.Random.Guid().ToString());
            }

            return guids;
        }

        public List<string> GenerateListGuidInvalid(int quantity)
        {
            var guids = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                guids.Add(faker.Random.String());
            }

            return guids;
        }
        public void Dispose()
        {
            
        }
    }
}
