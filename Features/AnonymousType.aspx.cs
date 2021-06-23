using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Features_AnonymousType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var hussein = new { name = "Hussein", age = 39, job = "Developer", Kids = new { first = "Mariam", second = "Jana", third = "Ahmed" } };
      
        var team = new[] { new { id = 1 }, new { id = 2 } };

        string first = "Mariam ", second = "Jana ", third = "Ahmed ";

        string childern =$"my kids are : {first} { second}{ third}";
        Response.Write(childern);
    }
  
}