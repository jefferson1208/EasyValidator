using EasyValidator.Tests.Entity;
using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Errors;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(StringCollection))]
    public class StringTests
    {
        private readonly StringTestsFixture _stringTestsFixture;

        public StringTests(StringTestsFixture stringTestsFixture)
        {
            this._stringTestsFixture = stringTestsFixture;
        }

        [Fact(DisplayName = "Validação de String. Tamanho mínimo")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccessWhenValueIsTrue()
        {
            //Arrange
            var samples = _stringTestsFixture.GenerateListNames(1000, 5);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.HasMinimumLength(sample.Name, 5, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. Não Nulo")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnErrorWhenValueIsNull()
        {
            //Arrange
            var quantity = 1000;
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < quantity; i++)
            {
                contract.IsNotNullOrEmpty(null, "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(quantity, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. Não Vazio")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnErrorWhenValueIsEmpty()
        {
            //Arrange
            var quantity = 1000;
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < quantity; i++)
            {
                contract.IsNotNullOrEmpty(string.Empty, "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(quantity, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. É Nulo")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccessWhenValueIsNull()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < 1000; i++)
            {
                contract.IsNullOrEmpty(null, "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. É Vazio")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccessWhenValueIsEmpty()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < 1000; i++)
            {
                contract.IsNullOrEmpty(string.Empty, "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. Tem espaço em branco")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccessWhenValueWithWhiteSpace()
        {
            //Arrange
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < 1000; i++)
            {
                contract.IsNullOrWhiteSpace(" ", "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. Não tem espaço em branco")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnErrorWhenValueWithWhiteSpace()
        {
            //Arrange
            var quantity = 1000;
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            for (int i = 0; i < quantity; i++)
            {
                contract.IsNotNullOrWhiteSpace(" ", "Sua mensagem caso ocorra erro aqui");
            }

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(quantity, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. Tamanho igual")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccessWhenValueHasLength()
        {
            //Arrange
            var size = 5;
            var samples = _stringTestsFixture.GenerateListNames(1000, size);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.HasLength(sample.Name, size, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. Tamanho diferente")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnErrorWhenValueIsDifferentSize()
        {
            //Arrange
            var quantity = 1000;
            var size = 5;
            var samples = _stringTestsFixture.GenerateListNames(quantity, size);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.HasLength(sample.Name, 4, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Invalid);
            Assert.Equal(quantity, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. Contem")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccesWhenValueContains()
        {
            //Arrange
            var size = 5;
            var samples = _stringTestsFixture.GenerateListNames(1000, size);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.Contains(string.Concat(sample.Name, "-", sample.Name), sample.Name, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. Não Contem")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccesWhenValueNotContains()
        {
            //Arrange
            var size = 5;
            var samples = _stringTestsFixture.GenerateListNames(1000, size);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            var index = 0;

            samples.ForEach(sample =>
            {
                contract.NotContains(string.Concat(sample.Name, "-", sample.Name), index.ToString(), "Sua mensagem caso ocorra erro aqui");
                index++;
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. Contem na lista")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccesWhenValueContainsInList()
        {
            //Arrange
            var size = 5;
            var samples = _stringTestsFixture.GenerateListNames(1000, size);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.ContainsInList(sample, samples, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. Não contém na lista")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccesWhenValueNotContainsInList()
        {
            //Arrange
            var size = 5;
            var samples = _stringTestsFixture.GenerateListNames(1000, size);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            var index = 0;

            samples.ForEach(sample =>
            {
                contract.NotContainsInList(null, samples, "Sua mensagem caso ocorra erro aqui");
                index++;
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. E-mail válido")]
        [Trait("String", "Validação de E-mail")]
        public void ShouldReturnSuccesWhenValueIsEmail()
        {
            //Arrange
            var samples = _stringTestsFixture.GenerateListEmailsValid(1000);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsEmail(sample.Email, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. E-mail inválido")]
        [Trait("String", "Validação de E-mail")]
        public void ShouldReturnErrorWhenValueIsNotEmail()
        {
            //Arrange
            var samples = _stringTestsFixture.GenerateListEmailsInvalid(1000);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsNotEmail(sample.Email, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. URL válida")]
        [Trait("String", "Validação de URL")]
        public void ShouldReturnSuccesWhenValueIsUrl()
        {
            //Arrange
            var samples = _stringTestsFixture.GenerateListUrlsValid(1000);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsUrl(sample.Url, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }

        [Fact(DisplayName = "Validação de String. URL inválida")]
        [Trait("String", "Validação de URL")]
        public void ShouldReturnErrorWhenValueIsNotUrl()
        {
            //Arrange
            var samples = _stringTestsFixture.GenerateListUrlsInvalid(1000);
            var contract = new EasyValidatorContract<Sample>();

            //Act
            contract.Requires();
            samples.ForEach(sample =>
            {
                contract.IsNotUrl(sample.Url, "Sua mensagem caso ocorra erro aqui");
            });

            //Assert
            Assert.True(contract.Valid);
            Assert.Equal(0, contract.Errors.Count);
        }
    }
}
