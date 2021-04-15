using EasyValidator.Tests.Entity;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    public class DateTimeTests
    {
        private readonly Sample _entity = new Sample();

        [Fact(DisplayName = "Validação de DateTime. Maior que")]
        [Trait("DateTime", "Validação de DateTime")]
        public void ShouldReturnSuccessWhenDateIsGreater()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            contract.IsGreater(Sample.DateTimeSnapshot, _entity.DateTimeGreaterThanNow, "Sua mensagem caso ocorra erro aqui");
            contract.IsGreater(Sample.DateTimeSnapshot, _entity.DateTimeGreaterThanNow, "Sua mensagem caso ocorra erro aqui");
            contract.IsGreater(Sample.DateTimeSnapshot, _entity.DateTimeLowerThanNow, "Sua mensagem caso ocorra erro aqui");
            contract.IsGreater(Sample.DateTimeSnapshot, _entity.DateTimeLowerThanNow, "Sua mensagem caso ocorra erro aqui");

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(2, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de DateTime. Maior ou igual a (maior)")]
        [Trait("DateTime", "Validação de DateTime")]
        public void ShouldReturnSuccessWhenDateIsGreaterOrEquals()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            contract.IsGreaterOrEquals(Sample.DateTimeSnapshot, _entity.DateTimeGreaterOrEqualsThanNow,
            "Sua mensagem caso ocorra erro aqui");
            contract.IsGreaterOrEquals(Sample.DateTimeSnapshot, _entity.DateTimeGreaterOrEqualsThanNow,
            "Sua mensagem caso ocorra erro aqui");
            contract.IsGreaterOrEquals(Sample.DateTimeSnapshot, _entity.DateTimeGreaterThanNow,
            "Sua mensagem caso ocorra erro aqui");
            contract.IsGreaterOrEquals(Sample.DateTimeSnapshot, _entity.DateTimeGreaterThanNow,
            "Sua mensagem caso ocorra erro aqui");

            contract.IsGreaterOrEquals(Sample.DateTimeSnapshot, _entity.DateTimeLowerThanNow,
            "Sua mensagem caso ocorra erro aqui");
            contract.IsGreaterOrEquals(Sample.DateTimeSnapshot, _entity.DateTimeLowerThanNow,
            "Sua mensagem caso ocorra erro aqui");

            //Assert
            Assert.False(contract.Valid);
            Assert.Equal(2, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de DateTime. Maior ou igual a (igual)")]
        [Trait("DateTime", "Validação de DateTime")]
        public void ShouldReturnSuccessWhenDateIsEquals()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            contract.IsGreaterOrEquals(Sample.DateTimeSnapshot, Sample.DateTimeSnapshot, "Sua mensagem caso ocorra erro aqui");
            contract.IsGreaterOrEquals(Sample.DateTimeSnapshot, Sample.DateTimeSnapshot, "Sua mensagem caso ocorra erro aqui");

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de DateTime. Menor que")]
        [Trait("DateTime", "Validação de DateTime")]
        public void ShouldReturnSuccessWhenDateIsLower()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            contract.IsLower(_entity.DateTimeLowerThanNow, Sample.DateTimeSnapshot, "A data informada deve ser menor que a atual");
            contract.IsLower(_entity.DateTimeLowerThanNow, Sample.DateTimeSnapshot, "A data informada deve ser menor que a atual");
            contract.IsLower(_entity.DateTimeLowerThanNow, Sample.DateTimeSnapshot, "A data informada deve ser menor que a atual");
            contract.IsLower(_entity.DateTimeLowerThanNow, Sample.DateTimeSnapshot, "A data informada deve ser menor que a atual");

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de DateTime. Menor ou igual a (igual)")]
        [Trait("DateTime", "Validação de DateTime")]
        public void ShouldReturnSuccessWhenDateIsLowerOrEquals()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            contract.IsLowerOrEquals(Sample.DateTimeSnapshot, Sample.DateTimeSnapshot, "A data informada deve ser menor que a atual");
            contract.IsLowerOrEquals(Sample.DateTimeSnapshot, Sample.DateTimeSnapshot, "A data informada deve ser menor que a atual");
            contract.IsLowerOrEquals(Sample.DateTimeSnapshot, Sample.DateTimeSnapshot, "A data informada deve ser menor que a atual");
            contract.IsLowerOrEquals(Sample.DateTimeSnapshot, Sample.DateTimeSnapshot, "A data informada deve ser menor que a atual");
            contract.IsLowerOrEquals(Sample.DateTimeSnapshot, Sample.DateTimeSnapshot, "A data informada deve ser menor que a atual");

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }
    }
}
