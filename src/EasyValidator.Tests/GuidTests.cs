using EasyValidator.Tests.Entity;
using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(GuidCollection))]
    public class GuidTests
    {
        private readonly GuidTestsFixture _guidTestsFixture;
        public GuidTests(GuidTestsFixture guidTestsFixture)
        {
            _guidTestsFixture = guidTestsFixture;
        }
        [Fact(DisplayName = "Validação de Guid. Válidos")]
        [Trait("Guid", "Validação de Guid")]
        public void ShouldReturnSuccessWhenGuidIsValid()
        {
            //Arrange
            var samples = _guidTestsFixture.GenerateListGuidValid(100);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsGuidNotEmpty(sample.Guid, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Guid. Inválidos")]
        [Trait("Guid", "Validação de Guid")]
        public void ShouldReturnErrorWhenGuidIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var samples = _guidTestsFixture.GenerateListGuidInvalid(quantity);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsGuidNotEmpty(sample.Guid, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(quantity, contract.Errors.Count);

        }
    }
}
