using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Features_Ternary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = 10, y = 100;

        string result = x > y ? "x is greater than y" :  x < y ? "x is less than y" :  x == y ? "x is equal to y" : "No result";
        Response.Write("result ="+result);
        Response.Write("<br>");
        string t = x > y ? "x bigger" : x == y ? "x equal" : x < y ? "x smaller" : "shit";
        Response.Write("t="+t);
    }
}