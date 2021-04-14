using EasyValidator.Validator.Errors;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    public class BoolTests : Notify
    {
        [Fact(DisplayName = "Validação de Boleano. Verdadeiro")]
        [Trait("Bool", "Validação de Boleano")]
        public void ShouldReturnSuccessWhenValueIsTrue()
        {
            //Arrange
            //Act

            for (int i = 0; i < 100; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsTrue(true, "Campo deve ser verdadeiro"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de Boleano. Falso")]
        [Trait("Bool", "Validação de Boleano")]
        public void ShouldReturnErrorWhenValueIsFalse()
        {
            //Arrange
            //Act

            for (int i = 0; i < 100; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsFalse(false, "Campo deve ser verdadeiro"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }
    }
}
