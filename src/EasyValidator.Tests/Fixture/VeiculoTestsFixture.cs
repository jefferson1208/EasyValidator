using EasyValidator.Tests.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace EasyValidator.Tests.Fixture
{
    [CollectionDefinition(nameof(VeiculoCollection))]
    public class VeiculoCollection : ICollectionFixture<VeiculoTestsFixture>
    {

    }
    public class VeiculoTestsFixture : IDisposable
    {
        public List<Sample> GenerateCarLicensePlate(int quantity, int lettersLength, int numberLength)
        {
            var licenses = new List<Sample>();

            for (int i = 0; i < quantity; i++)
                licenses.Add(new Sample { LicensePlate = string.Concat(GenerateLetters(lettersLength), GenerateNumbers(numberLength)) });

            return licenses;
        }

        public List<Sample> GenerateCarLicensePlateMercosul(int quantity, int lettersLength, int numberLength)
        {
            var licenses = new List<Sample>();

            for (int i = 0; i < quantity; i++)
                licenses.Add(new Sample { LicensePlate = string.Concat(GenerateLetters(lettersLength),
                GenerateNumbers(1),
                GenerateLetters(1),
                GenerateNumbers(numberLength))
                });

            return licenses;
        }

        private string GenerateLetters(int len)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, len)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());
            return result;
        }

        private string GenerateNumbers(int len)
        {
            var chars = "0123456789";
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
