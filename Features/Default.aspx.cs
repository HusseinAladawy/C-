using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Features_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int? i = null;
        int j = i??0;

        int? x = null;
     
        Response.Write(x.GetValueOrDefault());
        Response.Write("<br>");
       

        Response.Write(x.GetValueOrDefault());


    }
}