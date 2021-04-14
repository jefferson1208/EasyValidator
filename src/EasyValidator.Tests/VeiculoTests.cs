using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Errors;
using EasyValidator.Validator.Validations;
using System.Linq;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(VeiculoCollection))]
    public class VeiculoTests : Notify
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
            var plates = _veiculoTestsFixture.GenerateCarLicensePlate(100, 3, 4);

            //Act

            plates.ForEach(p =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .CarLicensePlate(p, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de Placas de veículos. Placas comuns Inválidas")]
        [Trait("Veículo", "Validação de Telefone")]
        public void ShouldReturnErrorWhenLicensePlateIsInvalid()
        {
            //Arrange

            var quantity = 100;
            var plates = _veiculoTestsFixture.GenerateCarLicensePlate(quantity, 5, 6);

            //Act

            plates.ForEach(p =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .CarLicensePlate(p, "Error"));
            });

            //Assert
            Assert.True(Errors.Count() == quantity);
        }

        [Fact(DisplayName = "Validação de Placas de veículos. Placas do mercosul Válidas")]
        [Trait("Veículo", "Validação de Telefone")]
        public void ShouldReturnSuccessWhenCarLicensePlateMercosulIsValid()
        {
            //Arrange
            var plates = _veiculoTestsFixture.GenerateCarLicensePlateMercosul(100, 3, 2);

            //Act

            plates.ForEach(p =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .CarLicensePlateMercosul(p, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de Placas de veículos. Placas do mercosul Válidas")]
        [Trait("Veículo", "Validação de Telefone")]
        public void ShouldReturnErrorWhenCarLicensePlateMercosulIsInvalid()
        {
            //Arrange
            var quantity = 100;
            var plates = _veiculoTestsFixture.GenerateCarLicensePlateMercosul(quantity, 3, 4);

            //Act

            plates.ForEach(p =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .CarLicensePlateMercosul(p, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == quantity);
        }
    }
}
