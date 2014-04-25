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
        XDocument xmlDoc = XDocument.Load("C:/Users/Gene/Documents/GitHub/TEST/TEST/TEST/Data/ExchangeRates.xml");
        

        public CurrencyConversion(decimal amt)
        {
            deciAmount = amt;
        }

        public decimal ConvertUSDToEUR(decimal amt)
        {
            try
            {
                decimal deciEUR = 0;
                IEnumerable<decimal> GetDeciRate = from rate in xmlDoc.Descendants("Cube")
                                   where (string)rate.Attribute("currency").Value == "USD"
                                   select (decimal)rate;
                decimal deciRate = GetDeciRate.First<decimal>();

                deciEUR = amt * deciRate;

                return Math.Round(deciEUR, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
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
