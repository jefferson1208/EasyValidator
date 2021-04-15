using Bogus;
using EasyValidator.Tests.Entity;
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

        public List<Sample> GenerateListCepValid(int quantity)
        {
            var ceps = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                ceps.Add(new Sample { Cep = faker.Person.Address.ZipCode });
            }

            return ceps;
        }

        public List<Sample> GenerateListCepInvalid(int quantity)
        {
            var ceps = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                ceps.Add(new Sample { Cep = faker.Random.Int().ToString() });
            }

            return ceps;
        }
    }
}
