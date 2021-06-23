using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _7_NewFeature_Digit_Separators : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var myData1 = 1__2________3___4____5_____6;
        var myData2 = 123_000.79;

        Response.Write("bigNumber "+ myData1);
        Response.Write("<br>");
        Response.Write("bigNumberSplit " + myData2);
        Response.Write("<br>");
       

    }
}