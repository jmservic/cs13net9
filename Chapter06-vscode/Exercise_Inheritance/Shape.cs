namespace Packt.Shared;

public class Shape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Area { get; set; }

    public Shape(double height, double width, double area)
    {
        Height = height;
        Width = width;
        Area = area;
    }
}

public class Rectangle : Shape
{
    public Rectangle(double height, double width) : base(height, width, height * width)
    {

    }
}

public class Square : Rectangle
{
    public Square(double side) : base(side, side)
    {

    }
}

public class Circle : Shape
{
    public Circle(double radius) : base(2 * radius, 2 * radius, Math.PI * radius * radius)
    {
        
    }
}