using EasyValidator.Tests.Fixture;
using EasyValidator.Validator.Errors;
using EasyValidator.Validator.Validations;
using Xunit;

namespace EasyValidator.Tests
{
    [Collection(nameof(StringCollection))]
    public class StringTests : Notify
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
            var listNames = _stringTestsFixture.GenerateListNames(1000, 5);

            //Act

            listNames.ForEach(n =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .HasMinimumLength(n, 5, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. Não Nulo")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnErrorWhenValueIsNull()
        {
            //Arrange
            var quantity = 1000;

            //Act

            for (int i = 0; i < quantity; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsNotNullOrEmpty(null, "Error"));
            }

            //Assert
            Assert.True(Errors.Count == quantity);
        }

        [Fact(DisplayName = "Validação de String. Não Vazio")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnErrorWhenValueIsEmpty()
        {
            //Arrange
            var quantity = 1000;

            //Act

            for (int i = 0; i < quantity; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsNotNullOrEmpty(string.Empty, "Error"));
            }

            //Assert
            Assert.True(Errors.Count == quantity);
        }

        [Fact(DisplayName = "Validação de String. É Nulo")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccessWhenValueIsNull()
        {
            //Arrange
            //Act

            for (int i = 0; i < 1000; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsNullOrEmpty(null, "Error"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. É Vazio")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccessWhenValueIsEmpty()
        {
            //Arrange
            //Act

            for (int i = 0; i < 1000; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsNullOrEmpty(string.Empty, "Error"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. Tem espaço em branco")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccessWhenValueWithWhiteSpace()
        {
            //Arrange
            //Act

            for (int i = 0; i < 1000; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsNullOrWhiteSpace(" ", "Error"));
            }

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. Não tem espaço em branco")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnErrorWhenValueWithWhiteSpace()
        {
            //Arrange
            var quantity = 1000;

            //Act

            for (int i = 0; i < quantity; i++)
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsNotNullOrWhiteSpace(" ", "Error"));
            }

            //Assert
            Assert.True(Errors.Count == quantity);
        }

        [Fact(DisplayName = "Validação de String. Tamanho igual")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccessWhenValueHasLength()
        {
            //Arrange
            var size = 5;
            var listNames = _stringTestsFixture.GenerateListNames(1000, size);

            //Act

            listNames.ForEach(n =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .HasLength(n, size, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. Tamanho diferente")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnErrorWhenValueIsDifferentSize()
        {
            //Arrange
            var quantity = 1000;
            var size = 5;
            var listNames = _stringTestsFixture.GenerateListNames(quantity, size);

            //Act

            listNames.ForEach(n =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .HasLength(n, 4, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == quantity);
        }

        [Fact(DisplayName = "Validação de String. Contem")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccesWhenValueContains()
        {
            //Arrange
            var size = 5;
            var listNames = _stringTestsFixture.GenerateListNames(1000, size);

            //Act

            listNames.ForEach(n =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .Contains(string.Concat(n, "-", n), n, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. Não Contem")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccesWhenValueNotContains()
        {
            //Arrange
            var size = 5;
            var listNames = _stringTestsFixture.GenerateListNames(1000, size);

            //Act
            var index = 0;

            listNames.ForEach(n =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .NotContains(string.Concat(n, "-", n), index.ToString(), "Error"));

                index++;
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. Contem na lista")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccesWhenValueContainsInList()
        {
            //Arrange
            var size = 5;
            var listNames = _stringTestsFixture.GenerateListNames(1000, size);

            //Act

            listNames.ForEach(n =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .ContainsInList(n, listNames, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. Não contém na lista")]
        [Trait("String", "Validação de String")]
        public void ShouldReturnSuccesWhenValueNotContainsInList()
        {
            //Arrange
            var size = 5;
            var listNames = _stringTestsFixture.GenerateListNames(1000, size);

            //Act

            var index = 0;

            listNames.ForEach(n =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .NotContainsInList(string.Concat(n, index), listNames, "Error"));
                index++;
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. E-mail válido")]
        [Trait("String", "Validação de E-mail")]
        public void ShouldReturnSuccesWhenValueIsEmail()
        {
            //Arrange
            var listEmails = _stringTestsFixture.GenerateListEmailsValid(1000);

            //Act
            listEmails.ForEach(email =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsEmail(email, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. E-mail inválido")]
        [Trait("String", "Validação de E-mail")]
        public void ShouldReturnErrorWhenValueIsNotEmail()
        {
            //Arrange
            var listEmails = _stringTestsFixture.GenerateListEmailsInvalid(1000);

            //Act
            listEmails.ForEach(email =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsNotEmail(email, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. URL válida")]
        [Trait("String", "Validação de URL")]
        public void ShouldReturnSuccesWhenValueIsUrl()
        {
            //Arrange
            var urls = _stringTestsFixture.GenerateListUrlsValid(1000);

            //Act
            urls.ForEach(url =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsUrl(url, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }

        [Fact(DisplayName = "Validação de String. URL inválida")]
        [Trait("String", "Validação de URL")]
        public void ShouldReturnErrorWhenValueIsNotUrl()
        {
            //Arrange
            var urls = _stringTestsFixture.GenerateListUrlsInvalid(1000);

            //Act
            urls.ForEach(url =>
            {
                AddErrors(new EasyValidatorContract()
                                        .Requires()
                                        .IsNotUrl(url, "Error"));
            });

            //Assert
            Assert.True(Errors.Count == 0);
        }
    }
}
