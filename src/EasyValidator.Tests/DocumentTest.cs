using EasyValidator.Tests.Enums;
using EasyValidator.Tests.Fixture;
using Xunit;
using EasyValidator.Validator.Validations;
using EasyValidator.Validator.Errors;

namespace EasyValidator.Tests
{
    [Collection(nameof(DocumentCollection))]
    public class DocumentTest : Notify
    {
        private readonly DocumentTestsFixture _documentTestsFixture;
        public DocumentTest(DocumentTestsFixture documentTestsFixture)
        {
            _documentTestsFixture = documentTestsFixture;
        }

        [Fact(DisplayName = "Validação de CPF. Válidos")]
        [Trait("CPF", "Validação de CPF")]
        public void ShouldReturnSuccessWhenCpfIsValid()
        {
            //Arrange
            var documents = _documentTestsFixture.GenerateDocumentsValid(100, EDocumentType.Cpf);

            //Act
            documents.ForEach(document =>
            {
                AddErrors(new EasyValidatorContract()
                                    .Requires()
                                    .IsCpf(document, "CPF Inválido"));

            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de CPF. Inválidos")]
        [Trait("CPF", "Validação de CPF")]
        public void ShouldReturnErrorWhenCpfIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var documents = _documentTestsFixture.GenerateDocumentsInvalid(quantity, EDocumentType.Cpf);

            //Act
            documents.ForEach(document =>
            {
                AddErrors(new EasyValidatorContract()
                                    .Requires()
                                    .IsCpf(document, "CPF Inválido"));

            });

            //Assert
            Assert.True(Errors.Count == quantity);
        }

        [Fact(DisplayName = "Validação de CNPJ. Válidos")]
        [Trait("CNPJ", "Validação de CNPJ")]
        public void ShouldReturnSuccessWhenCnpjIsValid()
        {
            //Arrange
            var documents = _documentTestsFixture.GenerateDocumentsValid(100, EDocumentType.Cnpj);

            //Act
            documents.ForEach(document =>
            {
                AddErrors(new EasyValidatorContract()
                                    .Requires()
                                    .IsCnpj(document, "CNPJ Inválido"));

            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de CNPJ. Inválidos")]
        [Trait("CNPJ", "Validação de CNPJ")]
        public void ShouldReturnErrorWhenCnpjIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var documents = _documentTestsFixture.GenerateDocumentsInvalid(quantity, EDocumentType.Cnpj);

            //Act
            documents.ForEach(document =>
            {
                AddErrors(new EasyValidatorContract()
                                    .Requires()
                                    .IsCnpj(document, "CNPJ Inválido"));
            });

            //Assert
            Assert.True(Errors.Count == quantity);
        }

        [Fact(DisplayName = "Validação de CNH. Válidas")]
        [Trait("CNH", "Validação de CNH")]
        public void ShouldReturnSuccessWhenCnhIsValid()
        {
            //Arrange
            var documents = _documentTestsFixture.GenerateCnhValid();

            //Act
            documents.ForEach(document =>
            {
                AddErrors(new EasyValidatorContract()
                                    .Requires()
                                    .IsCnh(document, string.Concat("CNH ", document, " inválida")));

            });

            //Assert
            Assert.True(Errors.Count == 0);
        }
    }
}
