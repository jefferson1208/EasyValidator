using EasyValidator.Validator.Errors;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    public class NumberTests : Notify
    {
        [Fact(DisplayName = "Validação de Números. Maior que")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberIsGreater()
        {
            //Arrange
            //Act
            for (int i = 0; i < 1000; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsGreater(i + 1, i, "Campo deve ser maior do que o informado"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de Números. Não é maior que")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberNotIsGreater()
        {
            //Arrange
            var quantity = 1000;

            //Act
            for (int i = 0; i < quantity; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsGreater(i, i + 1, "Campo deve ser maior do que o informado"));
            }

            //Assert
            Assert.True(Errors.Count == quantity);
        }

        [Fact(DisplayName = "Validação de Números. Igual a")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberIsEqual()
        {
            //Arrange
            //Act
            for (int i = 0; i < 1000; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsGreaterOrEquals(i, i, "Campo deve ser igual ao campo informado"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de Números. Menor que")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberIsLower()
        {
            //Arrange
            //Act
            for (int i = 0; i < 1000; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsLower(i, i + 1, "Campo deve ser menor do que o informado"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de Números. Igual a")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberAreEquals()
        {
            //Arrange
            //Act
            for (int i = 0; i < 1000; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .AreEquals(i, i, "Campo deve ser igual ao campo informado"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de Números. Não é igual a")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberAreNotEquals()
        {
            //Arrange
            //Act
            for (int i = 0; i < 1000; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .AreNotEquals(i, i + 1, "Campo deve ser diferente do campo informado"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de Números. Está entre")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberIsBetween()
        {
            //Arrange
            //Act
            for (int i = 0; i < 1000; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsBetween(i + 1, 0, 2000, "Campo deve estar entre 0 e 2000 do campo informado"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }
    }
}
