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
        XDocument xmlDoc = XDocument.Load("../../Data/ExchangeRates.xml");
        

        //GETS RATE OF EURO TO CALLED CURRENCY && ALL CREDIT TO ECB
        private decimal QueryBuilder(string curr)
        {
            decimal retValue = 0;
            var GetDeciRate = from todayDate in xmlDoc.Descendants("Cube")
                              where (string)todayDate.Attribute("currency") == curr
                              select todayDate.Attribute("rate").Value;

            foreach (var item in GetDeciRate)
            {
                retValue = decimal.Parse(item);
            }

            return retValue;
        }
        public CurrencyConversion(decimal amt)
        {
            deciAmount = amt;
            
        }

        public decimal ConvertUSDToEUR(decimal amt)
        {
            try
            {
                decimal deciEUR = 0;
                decimal deciRate = QueryBuilder("USD");

                deciEUR = amt * (1 / deciRate);

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
                decimal deciRate = QueryBuilder("USD");

                deciUSD = amt * deciRate;

                return Math.Round(deciUSD, 2);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
                
            }
        }

        public decimal ConcertUSDToMXN(decimal amt)
        {
            try
            {
                decimal deciPeso;
                decimal deciRate = QueryBuilder("USD");
 
                deciPeso = (amt * (QueryBuilder("MXN")*(1 / deciRate)));

                return Math.Round(deciPeso, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public decimal ConvertMXNToUSD(decimal amt)
        {
            try
            {
                decimal deciUSD;
                decimal deciRate = QueryBuilder("USD");

                deciUSD = amt / (QueryBuilder("MXN")*(1/deciRate));

                return Math.Round(deciUSD, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public decimal ConvertEURToJPY(decimal amt)
        {
            try
            {
                decimal deciJPY;
                decimal deciRate = QueryBuilder("JPY");

                deciJPY = amt * deciRate;

                return Math.Round(deciJPY, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
               
            }
        }

        public decimal ConvertJPYToEUR(decimal amt)
        {
            try
            {
                decimal deciEUR;
                decimal deciRate = QueryBuilder("JPY");

                deciEUR = amt / deciRate;

                return Math.Round(deciEUR, 2);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public decimal ConvertUSDToJPY(decimal amt)
        {
            try
            {
                decimal deciJPY;
                decimal deciRate = QueryBuilder("JPY");

                deciJPY = (amt * (1 / QueryBuilder("USD"))) * deciRate;

                return Math.Round(deciJPY, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public decimal ConvertJPYToUSD(decimal amt)
        {
            try
            {
                decimal deciUSD;
                decimal deciRate = QueryBuilder("USD");

                deciUSD = (amt * (1 / QueryBuilder("JPY")) * deciRate);

                return Math.Round(deciUSD, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
