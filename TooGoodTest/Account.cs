using System;
using System.Linq;

namespace TooGoodTest
{
    class Account : IAccount
    {
        public static bool HasHeader => true;

        public string AccountCode { get; set; }

        public string Name { get; set; }

        public AccountType Type { get; set; }

        public DateTime? OpenDate { get; set; }

        public Currency Currency { get; set; }

        public static string Header => string.Join(",", typeof(IAccount).GetProperties().Select(o => o.Name));
        public override string ToString() => $"{AccountCode},{Name},{Type},{OpenDate?.ToString("yyyy-MM-dd")},{Currency}";
    }

    class Account_1 : Account
    {
        enum Currency_1
        {
            CD, US
        };
        private string _identifier;
        private string _type;
        private string _opened;
        private string _currency;
        public static bool HasHeader => true;

        public Account_1(string identifier, string name, string type, string opened, string currency)
        {
            _identifier = identifier;
            _type = type;
            _opened = opened;
            _currency = currency;

            AccountCode = _identifier.Split(new char[] { '|' })[1];
            Name = name;
            Type = (AccountType)(int.Parse(_type));
            OpenDate = DateTime.ParseExact(_opened, "dd-MM-yyyy", null);
            Currency = (Currency)(int)Enum.Parse(typeof(Currency_1), _currency);
        }
    }

    class Account_2 : Account
    {
        enum Currency_2
        {
            C, U
        };
        private string _custodian_code;
        private string _type;
        private string _currency;
        public static bool HasHeader => false;
        public Account_2(string name, string type, string currency, string custodian_code)
        {
            _custodian_code = custodian_code;
            _type = type;
            _currency = currency;

            AccountCode = _custodian_code;
            Name = name;
            Type = (AccountType)Enum.Parse(typeof(AccountType), _type);
            OpenDate = null;
            Currency = (Currency)(int)Enum.Parse(typeof(Currency_2), _currency);
        }
    }
}
