using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.IO;


namespace TEST
{
    class CurrencyConversion
    {
        private decimal deciAmount { get; set; }
        XDocument xmlDoc;
        

        //GETS RATE OF EURO TO CALLED CURRENCY && ALL CREDIT TO ECB FOR UPDATED XML FILE
        private decimal GetCurrRate(string curr)
        {
            XMLMethods xmlMTD = new XMLMethods();
            xmlDoc = xmlMTD.RemoveAllNamespaces(xmlDoc.ToString());
            
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
        //CONSTRUCTOR; SETS AMOUNT PROPTERTY
        public CurrencyConversion(decimal amt, string path)
        {
            deciAmount = amt;
            xmlDoc = XDocument.Load(path);
            
        }
        //GETS inCurr IN EUR SINCE STANDARD IS EUR IN THIS CASE; THEN CONVERTS TO outCurr
        public decimal Convert(decimal amt, string inCurr, string outCurr)
        {
            try
            {
                decimal deciRetCurr = 0;
                decimal deciRate = GetCurrRate(outCurr);
                
                deciRetCurr = amt * ((1 / GetCurrRate(inCurr)) * deciRate);

                return Math.Round(deciRetCurr, 2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
           
        }

        //UPDATES FILE USING FILEUPDATE CLASS
        public void UpdateFile()
        {
            FileUpdate fileUp = new FileUpdate();
            try
            {
                fileUp.UpdateFile("../../Data/ExchangeRates.xml", fileUp.DownloadUpdate("http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }         
        }
    }
}
