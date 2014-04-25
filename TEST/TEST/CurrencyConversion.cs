using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace TEST
{
    class CurrencyConversion
    {
        public decimal deciAmount { get; set; }
        XDocument xmlDoc = XDocument.Load("~/Data/ExchangeRates.xml");
        

        public CurrencyConversion(decimal amt)
        {
            deciAmount = amt;
        }

        public decimal ConvertUSDToEUR(decimal amt)
        {
            try
            {
                decimal deciEUR = 0;
                IEnumerable<decimal> deciRate = from rate in xmlDoc.Root.Elements("Cube")
                                   where (string)rate.Attribute("currency") == "USD"
                                   select (decimal)rate.Attribute("rate");

                deciEUR = amt * decimal.Parse(deciRate);

                return Math.Round(deciEUR, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            
        }

        public decimal ConvertEURToUSD(decimal amt)
        {
            try
            {
                decimal deciUSD = 0;
                decimal deciRate = 1.38m;

                deciUSD = amt * deciRate;

                return Math.Round(deciUSD, 2);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public decimal ConcertUSDToPeso(decimal amt)
        {
            try
            {
                decimal deciPeso;
                decimal deciRate = 13.13m;

                deciPeso = amt * deciRate;

                return Math.Round(deciPeso, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public decimal ConvertPesoToUSD(decimal amt)
        {
            try
            {
                decimal deciUSD;
                decimal deciRate = .08m;

                deciUSD = amt * deciRate;

                return Math.Round(deciUSD, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
