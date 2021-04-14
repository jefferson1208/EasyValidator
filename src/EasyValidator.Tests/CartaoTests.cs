using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Errors;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(CartaoCollection))]
    public class CartaoTests : Notify
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
            var creditCards = _cartaoTestsFixture.GenereateCreditCardsValid();

            //Act

            creditCards.ForEach(card =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsCreditCard(card, "Error"));
            });
            

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de Cartão de Crédito. Inválidos")]
        [Trait("Cartão", "Validação de Cartão de Crédito")]
        public void ShouldReturnErrorWhenCreditCardIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var creditCards = _cartaoTestsFixture.GenereateCreditCardsInvalid(quantity);

            //Act

            creditCards.ForEach(card =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsCreditCard(card, "Error"));
            });


            //Assert
            Assert.True(Errors.Count == quantity);
        }
    }
}