using EasyValidator.Tests.Entity;
using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(VeiculoCollection))]
    public class VeiculoTests
    {
        private readonly VeiculoTestsFixture _veiculoTestsFixture;

        public VeiculoTests(VeiculoTestsFixture veiculoTestsFixture)
        {
            _veiculoTestsFixture = veiculoTestsFixture;
        }

        [Fact(DisplayName = "Validação de Placas de veículos. Placas comuns Válidas")]
        [Trait("Veículo", "Validação de Telefone")]
        public void ShouldReturnSuccessWhenLicensePlateIsValid()
        {
            //Arrange
            var samples = _veiculoTestsFixture.GenerateCarLicensePlate(100, 3, 4);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.CarLicensePlate(sample.LicensePlate, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Placas de veículos. Placas comuns Inválidas")]
        [Trait("Veículo", "Validação de Telefone")]
        public void ShouldReturnErrorWhenLicensePlateIsInvalid()
        {
            //Arrange

            var quantity = 100;
            var samples = _veiculoTestsFixture.GenerateCarLicensePlate(quantity, 5, 6);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.CarLicensePlate(sample.LicensePlate, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(quantity, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Placas de veículos. Placas do mercosul Válidas")]
        [Trait("Veículo", "Validação de Telefone")]
        public void ShouldReturnSuccessWhenCarLicensePlateMercosulIsValid()
        {
            //Arrange
            var samples = _veiculoTestsFixture.GenerateCarLicensePlateMercosul(100, 3, 2);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.CarLicensePlateMercosul(sample.LicensePlate, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de Placas de veículos. Placas do mercosul Válidas")]
        [Trait("Veículo", "Validação de Telefone")]
        public void ShouldReturnErrorWhenCarLicensePlateMercosulIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var samples = _veiculoTestsFixture.GenerateCarLicensePlateMercosul(quantity, 3, 4);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.CarLicensePlateMercosul(sample.LicensePlate, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(quantity, contract.Errors.Count);
        }
    }
}
