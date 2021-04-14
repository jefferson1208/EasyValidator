using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Errors;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(TelefoneCollection))]
    public class TelefoneTests : Notify
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
            var phones = _telefoneTestsFixture.GenerateListPhoneValid(100);

            //Act
            phones.ForEach(phone =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsPhone(phone, "Telefone é obrigatório"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de Telefone. Inválidos")]
        [Trait("Telefone", "Validação de Telefone")]
        public void ShouldReturnErrorWhenTelefoneIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var phones = _telefoneTestsFixture.GenerateListPhoneInvalid(quantity);

            //Act
            phones.ForEach(phone =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsPhone(phone, "Telefone é obrigatório"));
            });

            //Assert
            Assert.True(Errors.Count == quantity);

        }
    }
}
