using Bogus;
using Bogus.Extensions.Brazil;
using EasyValidator.Tests.Entity;
using EasyValidator.Tests.Enums;
using System;
using System.Collections.Generic;
using Xunit;

namespace EasyValidator.Tests.Fixture
{
    [CollectionDefinition(nameof(DocumentCollection))]
    public class DocumentCollection : ICollectionFixture<DocumentTestsFixture>
    {

    }
    public class DocumentTestsFixture : IDisposable
    {
        public List<Sample> GenerateDocumentsValid(int quantity, EDocumentType type)
        {

            var samples = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                if (type == EDocumentType.Cpf)
                    samples.Add(new Sample { Cpf = faker.Person.Cpf() });
                else
                    samples.Add(new Sample { Cnpj = faker.Company.Cnpj() });
            }

            return samples;
        }

        public List<Sample> GenerateDocumentsInvalid(int quantity, EDocumentType type)
        {

            var samples = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                if (type == EDocumentType.Cpf)
                    samples.Add(new Sample { Cpf = faker.Company.Cnpj() });
                else
                    samples.Add(new Sample { Cnpj = faker.Person.Cpf() });
            }

            return samples;
        }

        public List<Sample> GenerateCnhValid()
        {
            var documents = new List<Sample>();

            documents.Add(new Sample { Cnh = "35426956790" });
            documents.Add(new Sample { Cnh = "51390445011" });
            documents.Add(new Sample { Cnh = "18748600560" });
            documents.Add(new Sample { Cnh = "07866185842" });
            documents.Add(new Sample { Cnh = "77720603237" });
            documents.Add(new Sample { Cnh = "96495452515" });
            documents.Add(new Sample { Cnh = "77024223179" });
            documents.Add(new Sample { Cnh = "13292353122" });
            documents.Add(new Sample { Cnh = "32860601403" });
            documents.Add(new Sample { Cnh = "905687414-74" });
            documents.Add(new Sample { Cnh = "54123117117" });
            documents.Add(new Sample { Cnh = "15515545913" });
            documents.Add(new Sample { Cnh = "01270275045" });
            documents.Add(new Sample { Cnh = "71766977592" });
            documents.Add(new Sample { Cnh = "23069252843" });
            documents.Add(new Sample { Cnh = "43892490583" });
            documents.Add(new Sample { Cnh = "45956176381" });
            documents.Add(new Sample { Cnh = "45297212300" });
            documents.Add(new Sample { Cnh = "71190464642" });
            documents.Add(new Sample { Cnh = "78835101452" });
            documents.Add(new Sample { Cnh = "403712097-56" });

            return documents;
        }
        public void Dispose()
        {

        }
    }
}
