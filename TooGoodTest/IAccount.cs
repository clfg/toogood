using System;

namespace TooGoodTest
{
    interface IAccount
    { 
        string AccountCode { get; set; }
        string Name { get; set; }
        AccountType Type { get; set; }
        DateTime? OpenDate { get; set; }
        Currency Currency { get; set; }
    }

    enum AccountType
    {
        TRADING, RRSP, RESP, FUND
    }

    enum Currency
    {
        CAD, USD
    }
}
