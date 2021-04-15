using Bogus;
using EasyValidator.Tests.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EasyValidator.Tests.Fixture
{
    [CollectionDefinition(nameof(StringCollection))]
    public class StringCollection : ICollectionFixture<StringTestsFixture>
    {

    }
    public class StringTestsFixture : IDisposable
    {

        public List<Sample> GenerateListNames(int quantity, int len)
        {
            var samples = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker(locale: "pt_BR");

                samples.Add(new Sample { Name = faker.Person.FullName.Substring(0, len) });
            }

            return samples;

        }

        public List<Sample> GenerateListEmailsValid(int quantity)
        {
            var samples = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker(locale: "pt_BR");

                samples.Add(new Sample { Email = faker.Person.Email });
            }

            return samples;

        }

        public List<Sample> GenerateListEmailsInvalid(int quantity)
        {
            var samples = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker(locale: "pt_BR");

                samples.Add(new Sample { Email = faker.Person.FullName });
            }

            return samples;

        }

        public List<Sample> GenerateListUrlsValid(int quantity)
        {
            var samples = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                samples.Add(new Sample { Url = string.Concat("https://www.", GenerateLetters(10), ".com.br") });
            }

            return samples;

        }

        public List<Sample> GenerateListUrlsInvalid(int quantity)
        {
            var samples = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker(locale: "pt_BR");
                samples.Add(new Sample { Url = faker.Person.Website });
            }

            return samples;

        }

        private string GenerateLetters(int len)
        {
            var chars = "abcdefghijklmnopqrstuvwxyz";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, len)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }
        public void Dispose()
        {
            
        }
    }
}
