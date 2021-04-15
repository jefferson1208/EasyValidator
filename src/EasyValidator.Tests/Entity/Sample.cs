using System;

namespace EasyValidator.Tests.Entity
{
    public class Sample
    {
        public bool BoolTrueProperty = true;
        public bool BoolFalseProperty = false;

        public string CreditCard { get; set; }
        public string Cep { get; set; }
        public string Cpf { get; set; }
        public string Cnpj { get; set; }
        public string Cnh { get; set; }
        public string Phone { get; set; }
        public string LicensePlate { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }

        public static DateTime DateTimeSnapshot = DateTime.Now;
        public DateTime DateTimeGreaterThanNow = DateTimeSnapshot.AddHours(1);
        public DateTime DateTimeLowerThanNow = DateTimeSnapshot.AddHours(-1);
        public DateTime DateTimeGreaterOrEqualsThanNow = DateTimeSnapshot;

        public string Guid { get; set; }
    }
}