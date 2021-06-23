using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _7_NewFeature_Tuples : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Tuple<int, string, string> person =
                        new Tuple<int, string, string>(1, "Steve", "Jobs");
        (string name, string job, int id) me = ("hussein","abd elgawad",1);
        

   
    }
}