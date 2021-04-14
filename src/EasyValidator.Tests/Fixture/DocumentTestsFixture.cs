using Bogus;
using Bogus.Extensions.Brazil;
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
        public List<string> GenerateDocumentsValid(int quantity, EDocumentType type)
        {

            var documents = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                if (type == EDocumentType.Cpf)
                    documents.Add(faker.Person.Cpf());
                else
                    documents.Add(faker.Company.Cnpj());
            }

            return documents;
        }

        public List<string> GenerateDocumentsInvalid(int quantity, EDocumentType type)
        {

            var documents = new List<string>();

            for (int i = 0; i < quantity; i++)
            {
                var faker = new Faker("pt_BR");

                if (type == EDocumentType.Cpf)
                    documents.Add(faker.Company.Cnpj());
                else
                    documents.Add(faker.Person.Cpf());
            }

            return documents;
        }

        public List<string> GenerateCnhValid()
        {
            var documents = new List<string>();

            documents.Add("35426956790");
            documents.Add("51390445011");
            documents.Add("18748600560");
            documents.Add("07866185842");
            documents.Add("77720603237");
            documents.Add("96495452515");
            documents.Add("77024223179");
            documents.Add("13292353122");
            documents.Add("32860601403");
            documents.Add("905687414-74");
            documents.Add("54123117117");
            documents.Add("15515545913");
            documents.Add("01270275045");
            documents.Add("71766977592");
            documents.Add("23069252843");
            documents.Add("43892490583");
            documents.Add("45956176381");
            documents.Add("45297212300");
            documents.Add("71190464642");
            documents.Add("78835101452");
            documents.Add("403712097-56");

            return documents;
        }
        public void Dispose()
        {

        }
    }
}
