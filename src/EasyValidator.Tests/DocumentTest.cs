using EasyValidator.Tests.Entity;
using EasyValidator.Tests.Enums;
using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Validations;
using Xunit;
namespace EasyValidator.Tests
{
    [Collection(nameof(DocumentCollection))]
    public class DocumentTest
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
            var samples = _documentTestsFixture.GenerateDocumentsValid(100, EDocumentType.Cpf);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsCpf(sample.Cpf, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de CPF. Inválidos")]
        [Trait("CPF", "Validação de CPF")]
        public void ShouldReturnErrorWhenCpfIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var samples = _documentTestsFixture.GenerateDocumentsInvalid(quantity, EDocumentType.Cpf);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsCpf(sample.Cpf, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.False(contract.Valid);
            Assert.Equal(quantity, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de CNPJ. Válidos")]
        [Trait("CNPJ", "Validação de CNPJ")]
        public void ShouldReturnSuccessWhenCnpjIsValid()
        {
            //Arrange
            var samples = _documentTestsFixture.GenerateDocumentsValid(100, EDocumentType.Cnpj);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsCnpj(sample.Cnpj, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de CNPJ. Inválidos")]
        [Trait("CNPJ", "Validação de CNPJ")]
        public void ShouldReturnErrorWhenCnpjIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var samples = _documentTestsFixture.GenerateDocumentsInvalid(quantity, EDocumentType.Cnpj);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsCnpj(sample.Cnpj, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.False(contract.Valid);
            Assert.Equal(quantity, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de CNH. Válidas")]
        [Trait("CNH", "Validação de CNH")]
        public void ShouldReturnSuccessWhenCnhIsValid()
        {
            //Arrange
            var samples = _documentTestsFixture.GenerateCnhValid();
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsCnh(sample.Cnh, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }
    }
}
