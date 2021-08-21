using EasyValidator.Tests.Entity;
using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(CepCollection))]
    public class CepTests
    {
        private readonly CepTestsFixture _cepTestsFixture;
        public CepTests(CepTestsFixture cepTestsFixture)
        {
            _cepTestsFixture = cepTestsFixture;
        }

        [Fact(DisplayName = "Validação de CEP. Válidos")]
        [Trait("CEP", "Validação de CEP")]
        public void ShouldReturnSuccessWhenCepIsValid()
        {
            //Arrange
            var samples = _cepTestsFixture.GenerateListCepValid(100);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsCep(sample.Cep, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.Equal(0, contract.Errors.Count);
            Assert.True(contract.Valid);
        }

        [Fact(DisplayName = "Validação de CEP. Inválidos")]
        [Trait("CEP", "Validação de CEP")]
        public void ShouldReturnErrorWhenCepIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var samples = _cepTestsFixture.GenerateListCepInvalid(quantity);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsCep(sample.Cep, "Sua mensagem caso ocorra erro aqui");

            });

            //Assert
            Assert.Equal(quantity, contract.Errors.Count);
            Assert.False(contract.Valid);
        }
    }
}
