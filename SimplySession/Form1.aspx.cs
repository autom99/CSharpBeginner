using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Form1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnRedirect_Click(object sender, EventArgs e)
    {
        Session["UserName"] = TxtName.Text;
        Response.Redirect("Form2.aspx");
    }
}