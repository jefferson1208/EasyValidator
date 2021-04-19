using EasyValidator.Tests.Entity;
using EasyValidator.Validator.Validations;
using System.Collections.Generic;
using Xunit;

namespace EasyValidator.Tests
{
    public class NumberTests
    {
        [Fact(DisplayName = "Validação de Números. Maior que")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberIsGreater()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < 1000; i++)
            {
                contract.IsGreater(i + 1, i, "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Números. Não é maior que")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberNotIsGreater()
        {
            //Arrange
            var quantity = 1000;
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < quantity; i++)
            {
                contract.IsGreater(i, i + 1, "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(quantity, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Números. Igual a")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberIsEqual()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < 1000; i++)
            {
                contract.IsGreaterOrEquals(i, i, "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Números. Menor que")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberIsLower()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < 1000; i++)
            {
                contract.IsLower(i, i + 1, "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Números. Igual a")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberAreEquals()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < 1000; i++)
            {
                contract.IsGreaterOrEquals(i, i, "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Números. Não é igual a")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberAreNotEquals()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < 1000; i++)
            {
                contract.AreNotEquals(i, i + 1, "Sua mensagem caso ocorra erro aqui");

            }

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Números. Está entre")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberIsBetween()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < 1000; i++)
            {
                contract.IsBetween(i + 1, 0, 2000, "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Números. Contem na lista")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenNumberContainsInList()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();
            var samples = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Act
            contract.Requires();
            for (int i = 0; i < 1000; i++)
            {
                contract.ContainsInList(i, samples, "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(989, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Números. Um valor primário ou secundário é informado")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnSuccessWhenAPrimaryOrSecundaryNumberIsEntered()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            contract.OneOrAnother(1, 0, "Sua mensagem caso ocorra erro aqui");
            contract.OneOrAnother(0, 1, "Sua mensagem caso ocorra erro aqui");
            contract.OneOrAnother(1, 0, "Sua mensagem caso ocorra erro aqui");
            contract.OneOrAnother(1, 10, "Sua mensagem caso ocorra erro aqui");
            contract.OneOrAnother(0, 1, "Sua mensagem caso ocorra erro aqui");

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Números. Um valor primário ou secundário não é informado")]
        [Trait("Number", "Validação de Números")]
        public void ShouldReturnErrorWhenAPrimaryOrSecundaryNumberIsNotEntered()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            contract.OneOrAnother(0, 0, "Sua mensagem caso ocorra erro aqui");
            contract.OneOrAnother(0, 0, "Sua mensagem caso ocorra erro aqui");
            contract.OneOrAnother(0, 0, "Sua mensagem caso ocorra erro aqui");
            contract.OneOrAnother(0, 0, "Sua mensagem caso ocorra erro aqui");
            contract.OneOrAnother(0, 0, "Sua mensagem caso ocorra erro aqui");

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(5, contract.Errors.Count);
        }
    }
}
