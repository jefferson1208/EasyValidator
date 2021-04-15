using EasyValidator.Tests.Entity;
using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(CartaoCollection))]
    public class CartaoTests
    {
        private readonly CartaoTestsFixture _cartaoTestsFixture;

        public CartaoTests(CartaoTestsFixture cartaoTestsFixture)
        {
            _cartaoTestsFixture = cartaoTestsFixture;
        }

        [Fact(DisplayName = "Validação de Cartão de Crédito. Válidos")]
        [Trait("Cartão", "Validação de Cartão de Crédito")]
        public void ShouldReturnSuccessWhenCreditCardIsValid()
        {
            //Arrange
            var samples = _cartaoTestsFixture.GenereateCreditCardsValid();
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsCreditCard(sample.CreditCard, "Sua mensagem caso ocorra erro aqui");
            });


            //Assert
            Assert.Equal(0, contract.Errors.Count);
            Assert.True(contract.Valid);
        }

        [Fact(DisplayName = "Validação de Cartão de Crédito. Inválidos")]
        [Trait("Cartão", "Validação de Cartão de Crédito")]
        public void ShouldReturnErrorWhenCreditCardIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var samples = _cartaoTestsFixture.GenereateCreditCardsInvalid(quantity);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsCreditCard(sample.CreditCard, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.Equal(quantity, contract.Errors.Count);
            Assert.True(contract.Invalid);
        }
    }
}