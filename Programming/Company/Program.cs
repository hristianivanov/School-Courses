using System;
using System.Collections.Generic;
using System.Linq;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            //ST MIRAGE 12.10.2003 BG12984622 Ivaylo Mitev 5000 23000
            //LC KOBALT 30.09.1998 BG45990781 U002384 175800
            //LC ELMTARYD 09.05.1984 BG17832204 U000926 200100
            //ST NESTOROV 07.12.2011 BG69331934 Vladimir Nestorov 5000 165000
            //END


            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            
            List<Company> companies = new List<Company>();
            List<double> profit = new List<double>();

            while (input[0] != "END")
            {
                string type = input[0];
                if (type == "ST" || type == "LC")
                {
                    string name = input[1];
                    string date = input[2];
                    string bulstat = input[3];
                    double earning = 0;
                    
                    if (type == "ST")
                    {
                        string traderName = input[4]+input[5];
                        double startCapital = double.Parse(input[6]);
                        double capital = double.Parse(input[7]);
                        SoleTrader soleTrader = new SoleTrader(name, date, bulstat, traderName, startCapital, capital);
                        earning = soleTrader.Capital - soleTrader.StartCapital - soleTrader.Duty();
                        companies.Add(soleTrader);
                    }
                    else
                    {
                        string id = input[4];
                        double capital = double.Parse(input[5]);
                        LimitedCompany limitedCompany = new LimitedCompany(name, date, bulstat, id, capital);
                        earning = limitedCompany.Capital - limitedCompany.Duty();
                        companies.Add(limitedCompany);
                    }

                    profit.Add(earning);
                }



                input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            }

            for (int i = 0; i < companies.Count; i++)
            {
                Console.WriteLine($"{companies[i].Bulstat} {companies[i].Name} {profit[i]:f2}leva.");
            }
            //BG12984622 MIRAGE 15300.00 лв.

        }
    }
}
