using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Form2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    
{
        if (!Page.IsPostBack)
        {
            if (Session["UserName"] != null && Session["UserName"] != "")
            {
                LblName.Text = Convert.ToString(Session["UserName"]);
            }
            else
            {
                LblName.Text = "Guest User!!";
            }
        }
    }
}