using EasyValidator.Tests.Entity;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    public class BoolTests
    {
        private readonly Sample _entity = new Sample();

        [Fact(DisplayName = "Validação de Boleano. Verdadeiro")]
        [Trait("Bool", "Validação de Boleano")]
        public void ShouldReturnSuccessWhenValueIsTrue()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>()
                    .Requires()
                    .IsTrue(_entity.BoolTrueProperty, "Sua mensagem caso ocorra erro aqui")
                    .IsTrue(_entity.BoolTrueProperty, "Sua mensagem caso ocorra erro aqui")
                    .IsTrue(_entity.BoolFalseProperty, "Sua mensagem caso ocorra erro aqui")
                    .IsTrue(_entity.BoolFalseProperty, "Sua mensagem caso ocorra erro aqui");
            //Act

            //Assert
            Assert.False(contract.Valid);
            Assert.Equal(2, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Boleano. Falso")]
        [Trait("Bool", "Validação de Boleano")]
        public void ShouldReturnErrorWhenValueIsFalse()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>()
                    .Requires()
                    .IsFalse(_entity.BoolTrueProperty, "Sua mensagem caso ocorra erro aqui")
                    .IsFalse(_entity.BoolTrueProperty, "Sua mensagem caso ocorra erro aqui")
                    .IsFalse(_entity.BoolFalseProperty, "Sua mensagem caso ocorra erro aqui")
                    .IsFalse(_entity.BoolFalseProperty, "Sua mensagem caso ocorra erro aqui");
            //Act

            //Assert
            Assert.False(contract.Valid);
            Assert.Equal(2, contract.Errors.Count);
        }
    }
}
