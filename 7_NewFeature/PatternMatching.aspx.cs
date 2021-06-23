using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _7_NewFeature_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Circle circle = new Circle(10);
        New_Practice_DisplayArea(circle);
        Response.Write("<br>");
        Rectangle rectangle = new Rectangle(10, 5);
        New_Practice_DisplayArea(rectangle);
        Response.Write("<br>");
        Triangle triangle = new Triangle(10, 5);
        New_Practice_DisplayArea(triangle);
        Response.Write("<br>");
    }
    public  void Old_Practice_DisplayArea(Shape shape)
    {
        if (shape is Circle)
        {
            Circle c = (Circle)shape;
            Response.Write("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
        }
        else if (shape is Rectangle)
        {
            Rectangle r = (Rectangle)shape;
            Response.Write("Area of Rectangle is : " + r.Length * r.Height);
        }
        else if (shape is Triangle)
        {
            Triangle t = (Triangle)shape;
            Response.Write("Area of Triangle is : " + 0.5 * t.Base * t.Height);
        }
        else
        {
            throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
        }
    }
    public  void New_Practice_DisplayArea(Shape shape)
    {
        if (shape is Circle c)
        {
            Response.Write("Area of Circle is : " + c.Radius * c.Radius * Shape.PI);
        }
        else if (shape is Rectangle r)
        {
            Response.Write("Area of Rectangle is : " + r.Length * r.Height);
        }
        else if (shape is Triangle t)
        {
            Response.Write("Area of Triangle is : " + 0.5 * t.Base * t.Height);
        }
        else
        {
            throw new ArgumentException(message: "Invalid Shape", paramName: nameof(shape));
        }
    }

}
public class Shape
{
    public const float PI = 3.14f;
}
public class Circle : Shape
{
    public double Radius { get; }
    public Circle(double radius)
    {
        Radius = radius;
    }
}
public class Rectangle : Shape
{
    public double Length { get; }
    public double Height { get; }
    public Rectangle(double length, double height)
    {
        Length = length;
        Height = height;
    }
}
public class Triangle : Shape
{
    public double Base { get; }
    public double Height { get; }
    public Triangle(double @base, double height)
    {
        Base = @base;
        Height = height;
    }
}