using Bogus;
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

        public List<string> GenerateListNames(int quantity, int len)
        {
            var listNames = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker(locale: "pt_BR");

                listNames.Add(faker.Person.FullName.Substring(0, len));
            }

            return listNames;

        }

        public List<string> GenerateListEmailsValid(int quantity)
        {
            var listEmails = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker(locale: "pt_BR");

                listEmails.Add(faker.Person.Email);
            }

            return listEmails;

        }

        public List<string> GenerateListEmailsInvalid(int quantity)
        {
            var listEmails = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker(locale: "pt_BR");

                listEmails.Add(faker.Person.FullName);
            }

            return listEmails;

        }

        public List<string> GenerateListUrlsValid(int quantity)
        {
            var urls = new List<string>();

            for (int i = 0; i < quantity; i++)
            {                
                urls.Add(string.Concat("https://www.", GenerateLetters(10), ".com.br"));
            }

            return urls;

        }

        public List<string> GenerateListUrlsInvalid(int quantity)
        {
            var urls = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker(locale: "pt_BR");
                urls.Add(faker.Person.Website);
            }

            return urls;

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
