using EasyValidator.Tests.Entity;
using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(TelefoneCollection))]
    public class TelefoneTests
    {
        private readonly TelefoneTestsFixture _telefoneTestsFixture;
        public TelefoneTests(TelefoneTestsFixture telefoneTestsFixture)
        {
            _telefoneTestsFixture = telefoneTestsFixture;
        }

        [Fact(DisplayName = "Validação de Telefone. Válidos")]
        [Trait("Telefone", "Validação de Telefone")]
        public void ShouldReturnSuccessWhenTelefoneIsValid()
        {
            //Arrange
            var samples = _telefoneTestsFixture.GenerateListPhoneValid(100);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsPhone(sample.Phone, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Telefone. Inválidos")]
        [Trait("Telefone", "Validação de Telefone")]
        public void ShouldReturnErrorWhenTelefoneIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var samples = _telefoneTestsFixture.GenerateListPhoneInvalid(quantity);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsPhone(sample.Phone, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(quantity, contract.Errors.Count);

        }
    }
}
