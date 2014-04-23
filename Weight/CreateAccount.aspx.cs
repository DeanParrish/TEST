using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnReset_Click(object sender, EventArgs e)
    {
        txtEMail.Text = "";
        txtLastName.Text = "";
        txtFirstName.Text = "";
        txtWeight.Text = "";
        txtHeightFoot.Text = "";
        txtHeightInch.Text = "";

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Hub.aspx");
    }
}