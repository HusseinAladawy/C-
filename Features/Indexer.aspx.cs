using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Features_Indexer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


        myKids mk = new myKids();
        Response.Write("My first kid is :"+mk[1]);
        

        Response.Write("<br>");

        Response.Write("My first kid is :" + mk[1]);
    }
 }
class kids
{
    public int ID { get; set; }
    public string name { get; set; }
     

}
class myKids 
{
    List<kids> HusseinKids;
    public myKids() 
    {
        HusseinKids = new List<kids>();
        HusseinKids.Add(new kids { ID = 1, name ="Mariam"});
        HusseinKids.Add(new kids { ID = 2, name = "Jana"});
        HusseinKids.Add(new kids { ID = 2, name = "Ahmed"});

    }
    public string this[int KID]
    {
        get
        {
            return HusseinKids.FirstOrDefault(k => k.ID == KID).name;
        }
        set
        {
            HusseinKids.FirstOrDefault(k => k.ID == KID).name=value;
        }

    }
}