using System;
using System.Collections.Generic;

namespace TooGoodTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Account.HasHeader)
                Console.WriteLine(Account.Header);
            var list_1 = ReadAccountFromFile1();
            foreach (var a in list_1)
            {
                Console.WriteLine(a.ToString());
            }
            var list_2 = ReadAccountFromFile2();
            foreach (var a in list_2)
            {
                Console.WriteLine(a.ToString());
            }
        }

        static List<IAccount> ReadAccountFromFile1()
        {
            var list = new List<IAccount>();
            list.Add(new Account_1("123|AaaCode", "name1", "2", "01-01-2018", "CD"));
            list.Add(new Account_1("456|BbbCode", "name2", "3", "01-01-2019", "US"));
            return list;
        }

        static List<IAccount> ReadAccountFromFile2()
        {
            var list = new List<IAccount>();
            list.Add(new Account_2("name3","RRSP", "C", "CccCode"));
            list.Add(new Account_2("name4", "FUND", "U", "DddCode"));
            return list;
        }
    }
}
