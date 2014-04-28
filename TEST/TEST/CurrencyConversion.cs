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
        public XDocument xmlDoc = XDocument.Load("../../Data/ExchangeRates.xml");
        
        

        //GETS RATE OF EURO TO CALLED CURRENCY && ALL CREDIT TO ECB
        private decimal GetCurrRate(string curr)
        {
            decimal retValue = 0;
            xmlDoc = RemoveAllNamespaces(xmlDoc.ToString());
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
        public CurrencyConversion(decimal amt)
        {
            deciAmount = amt;
            
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

        public XDocument RemoveAllNamespaces(string xmlDocument)
        {
            XElement xmlDocumentWithoutNs = RemoveAllNamespaces(XElement.Parse(xmlDocument));

            XDocument xmlDocumentRet = new XDocument();

            xmlDocumentRet.Add(xmlDocumentWithoutNs);

            return xmlDocumentRet;
        }

        private static XElement RemoveAllNamespaces(XElement xmlDocument)
        {
            if (!xmlDocument.HasElements)
            {
                XElement xElement = new XElement(xmlDocument.Name.LocalName);
                xElement.Value = xmlDocument.Value;

                foreach (XAttribute attribute in xmlDocument.Attributes())
                    xElement.Add(attribute);

                return xElement;
            }
            return new XElement(xmlDocument.Name.LocalName, xmlDocument.Elements().Select(el => RemoveAllNamespaces(el)));
        }
    }
}
