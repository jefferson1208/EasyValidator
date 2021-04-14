using EasyValidator.Validator.Errors;
using EasyValidator.Validator.Validations;
using System;
using Xunit;

namespace EasyValidator.Tests
{
    public class DateTimeTests : Notify
    {
        [Fact(DisplayName = "Validação de DateTime. Maior que")]
        [Trait("DateTime", "Validação de DateTime")]
        public void ShouldReturnSuccessWhenDateIsGreater()
        {
            //Arrange
            //Act

            for (int i = 0; i < 100; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsGreater(DateTime.Now.AddDays(i + 1), DateTime.Now, "Data deve ser maior que a atual"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de DateTime. Maior ou igual a (maior)")]
        [Trait("DateTime", "Validação de DateTime")]
        public void ShouldReturnSuccessWhenDateIsGreaterOrEquals()
        {
            //Arrange
            var date = DateTime.Now;

            //Act

            for (int i = 0; i < 100; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsGreaterOrEquals(DateTime.Now.AddDays(i + 1), date,
                                        "As data informada deve ser maior ou igual a atual"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de DateTime. Maior ou igual a (igual)")]
        [Trait("DateTime", "Validação de DateTime")]
        public void ShouldReturnSuccessWhenDateIsEquals()
        {
            //Arrange
            var date = DateTime.Now;

            //Act

            for (int i = 0; i < 100; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsGreaterOrEquals(date, date, "As datas devem ser iguais"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de DateTime. Menor que")]
        [Trait("DateTime", "Validação de DateTime")]
        public void ShouldReturnSuccessWhenDateIsLower()
        {
            //Arrange
            var date = DateTime.Now;

            //Act

            for (int i = 0; i < 100; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsLower(date.AddDays(-(i + 1)), date, "A data informada deve ser menor que a atual"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de DateTime. Menor ou igual a (igual)")]
        [Trait("DateTime", "Validação de DateTime")]
        public void ShouldReturnSuccessWhenDateIsLowerOrEquals()
        {
            //Arrange
            var date = DateTime.Now;

            //Act

            for (int i = 0; i < 100; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsLowerOrEquals(date, date, "As datas devem ser iguais"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }
    }
}
