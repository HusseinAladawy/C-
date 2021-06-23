using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _7_NewFeature_OutVariable : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
       // OldPractice();
        NewPractice();



    }

    private void OldPractice()
    {
        string EmployeeName, Gender, Department;
        long Salary;
        GetEmployeeDetails(out EmployeeName, out Gender, out Salary, out Department);
        Response.Write("Employee Details:");
        Response.Write("<br>");
        Response.Write("Name: " + EmployeeName);
        Response.Write("<br>");
        Response.Write(" Gender:" + Gender);
        Response.Write("<br>");
        Response.Write(" Department:" + Department);
    }
    private void NewPractice()
    {
      
      
        GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department);
        Response.Write("Employee Details:");
        Response.Write("<br>");
        Response.Write("Name: " + EmployeeName);
        Response.Write("<br>");
        Response.Write(" Gender:" + Gender);
        Response.Write("<br>");
        Response.Write(" Department:" + Department);
    }

    static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
    {
        EmployeeName = "Mariam Hussein";
        Gender = "Female";
        Salary = 20000;
        Department = "IT";
    }
}