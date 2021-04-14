using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Errors;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(CepCollection))]
    public class CepTests : Notify
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
            var ceps = _cepTestsFixture.GenerateListCepValid(100);

            //Act
            ceps.ForEach(cep =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsCep(cep, "CEP é obrigatório"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de CEP. Inválidos")]
        [Trait("CEP", "Validação de CEP")]
        public void ShouldReturnErrorWhenCepIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var ceps = _cepTestsFixture.GenerateListCepInvalid(quantity);

            //Act
            ceps.ForEach(cep =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsCep(cep, "CEP é obrigatório"));
            });

            //Assert
            Assert.True(Errors.Count == quantity);

        }
    }
}
