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
    XDocument xmlDoc = XDocument.Load(HttpContext.Current.Server.MapPath("~/App_Data/ExchangeRates.xml"));
    ClassLibrary1.CCLibrary xx = new ClassLibrary1.CCLibrary(50, HttpContext.Current.Server.MapPath("~/App_Data/ExchangeRates.xml"));
    string[,] array = new string[,] { { "currency", "EUR" }, {"rate", "1"} };

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PopulateDDLFromXML(HttpContext.Current.Server.MapPath("~/App_Data/ExchangeRates.xml"), "currency", ddlCurrency1);
            PopulateDDLFromXML(HttpContext.Current.Server.MapPath("~/App_Data/ExchangeRates.xml"), "currency", ddlCurrency2);
            xx.UpdateFile(HttpContext.Current.Server.MapPath("~/App_Data/ExchangeRates.xml"), "http://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml");
            AppendElementXML(HttpContext.Current.Server.MapPath("~/App_Data/ExchangeRates.xml"), array);
        }  
    }
    private void AppendElementXML(string path, string[,] arr)
    {
        XDocument xmlDoc = XDocument.Load(path);
        var cubeRoot = from root in xmlDoc.Descendants("Cube")
                       where !root.HasAttributes
                       select root;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            //XElement parentElemtn = new XElement("Cube");
            XElement newElement = new XElement("Cube");
            for (int j = 0; j < arr.GetLength(1); j+=2)
            {
                XAttribute att = new XAttribute(arr[i, j].ToString(), arr[i, j + 1]);
                newElement.Add(att);
            }
            xmlDoc.Element("Cube").Add(newElement);
        }
        xmlDoc.Save(path);
    }
    private void PopulateDDLFromXML(string doc, string attribute, DropDownList list)
    {
        XDocument xmlDoc = XDocument.Load(doc);
        ClassLibrary1.XMLMethods xmlMTD = new ClassLibrary1.XMLMethods();
        xmlDoc = xmlMTD.RemoveAllNamespaces(xmlDoc.ToString());
       
        var getAttributes = from att in xmlDoc.Descendants("Cube")
                            where att.HasAttributes
                            orderby att.Attribute(attribute).Value
                            select att.Attribute(attribute).Value;
                            

        foreach (var item in getAttributes)
        {
            list.Items.Add(item.ToString());
        }


    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        try
        {
            lblResult.Text = xx.Convert(decimal.Parse(txtAmount.Text), ddlCurrency1.Text, ddlCurrency2.Text).ToString();
            
        }
        catch (Exception ex)
        {
            lblResult.Text = "ERROR";
            
        }
        
    }
}