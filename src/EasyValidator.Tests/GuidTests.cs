using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Errors;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(GuidCollection))]
    public class GuidTests : Notify
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
            var guids = _guidTestsFixture.GenerateListGuidValid(100);

            //Act
            guids.ForEach(guid =>
            {
                AddErrors(new EasyValidatorContract()
                                       .Requires()
                                       .IsGuidNotEmpty(guid, "Campo obrigatório"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de Guid. Inválidos")]
        [Trait("Guid", "Validação de Guid")]
        public void ShouldReturnErrorWhenGuidIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var guids = _guidTestsFixture.GenerateListGuidInvalid(quantity);

            //Act
            guids.ForEach(guid =>
            {
                AddErrors(new EasyValidatorContract()
                                       .Requires()
                                       .IsGuidNotEmpty(guid, "Campo obrigatório"));
            });

            //Assert
            Assert.True(Errors.Count == quantity);

        }
    }
}
