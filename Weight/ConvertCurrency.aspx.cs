using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;
using System.Xml;
using System.Xml.Linq;




public partial class CurrencyConversion : System.Web.UI.Page
{

    ClassLibrary1.CCLibrary xx = new ClassLibrary1.CCLibrary(50, HttpContext.Current.Server.MapPath("~/App_Data/ExchangeRates.xml"));
    protected void Page_Load(object sender, EventArgs e)
    {
        PopulateDDLFromXML(HttpContext.Current.Server.MapPath("~/App_Data/ExchangeRates.xml"), "currency");
    }

    private void PopulateDDLFromXML(string doc, string attribute)
    {
        XDocument xmlDoc = XDocument.Load(doc);
        ClassLibrary1.XMLMethods xmlMTD = new ClassLibrary1.XMLMethods();
        xmlDoc = xmlMTD.RemoveAllNamespaces(xmlDoc.ToString());
        
        var getAttributes = from att in xmlDoc.Descendants("Cube")
                            where att.HasAttributes
                            select att.Attribute(attribute);

        foreach (var item in getAttributes)
        {
            ddlCurrency1.Items.Add(item.ToString());   
        }


    }
}