using System;
using System.Collections.Generic;
using System.Linq;
using EasyValidator.Tests.Entity;
using Xunit;

namespace EasyValidator.Tests.Fixture
{
    [CollectionDefinition(nameof(CartaoCollection))]
    public class CartaoCollection : ICollectionFixture<CartaoTestsFixture>
    {

    }
    public class CartaoTestsFixture : IDisposable
    {
        public List<Sample> GenereateCreditCardsValid()
        {
            var creditCards = new List<Sample>();

            creditCards.Add(new Sample { CreditCard = "5187 6806 0695 1922" });
            creditCards.Add(new Sample { CreditCard = "4485 5605 4933 9694" });
            creditCards.Add(new Sample { CreditCard = "3474 130241 59946" });
            creditCards.Add(new Sample { CreditCard = "3038 114497 6964" });
            creditCards.Add(new Sample { CreditCard = "6011 8104 1512 9135" });
            creditCards.Add(new Sample { CreditCard = "2149 6468781 5141" });
            creditCards.Add(new Sample { CreditCard = "3598 0556 7708 4929" });
            creditCards.Add(new Sample { CreditCard = "86994 0891 03609 4" });
            creditCards.Add(new Sample { CreditCard = "6062 8232 9900 3365" });
            creditCards.Add(new Sample { CreditCard = "5088 3631 7253 5474" });
            creditCards.Add(new Sample { CreditCard = "5594 6969 6159 8071" });
            creditCards.Add(new Sample { CreditCard = "4532 2057 8438 8039" });
            creditCards.Add(new Sample { CreditCard = "3449 572483 35180" });
            creditCards.Add(new Sample { CreditCard = "3640 795796 2322" });
            creditCards.Add(new Sample { CreditCard = "6011 9717 2223 1558" });
            creditCards.Add(new Sample { CreditCard = "2149 0835482 8390" });
            creditCards.Add(new Sample { CreditCard = "3587 0786 9300 3288" });
            creditCards.Add(new Sample { CreditCard = "6062 8291 5941 1614" });
            creditCards.Add(new Sample { CreditCard = "5065 1887 3859 4708" });
            creditCards.Add(new Sample { CreditCard = "5034 0476 5174 6984" });
            creditCards.Add(new Sample { CreditCard = "6062 8269 3375 5480" });
            creditCards.Add(new Sample { CreditCard = "86999 2069 34866 0" });
            creditCards.Add(new Sample { CreditCard = "3576 8210 5122 6956" });
            creditCards.Add(new Sample { CreditCard = "2149 8117181 2236" });
            creditCards.Add(new Sample { CreditCard = "6011 7789 8362 8921" });
            creditCards.Add(new Sample { CreditCard = "3002 183955 8400" });
            creditCards.Add(new Sample { CreditCard = "3431 612185 86960" });
            creditCards.Add(new Sample { CreditCard = "4916 5780 6841 7302" });
            creditCards.Add(new Sample { CreditCard = "5291 9131 8781 9405" });

            return creditCards;
        }

        public List<Sample> GenereateCreditCardsInvalid(int quantity)
        {
            var chars = "123456789";
            var creditCards = new List<Sample>();

            for (int i = 0; i < quantity; i++)
            {
                var random = new Random();
                var result = new string(
                    Enumerable.Repeat(chars, 13)
                              .Select(s => s[random.Next(s.Length)])
                              .ToArray());

                creditCards.Add(new Sample { CreditCard = result });
            }



            return creditCards;
        }
        public void Dispose()
        {

        }
    }
}
