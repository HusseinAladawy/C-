using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Partial_Inheritance
/// </summary>
public class Partial_Inheritance
{
    public Partial_Inheritance()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public class user
    { 
    }
    public class human
    {
    }
    public partial class Employee
    {
       
    }
    public partial class Employee : human
    {
      
    }
}