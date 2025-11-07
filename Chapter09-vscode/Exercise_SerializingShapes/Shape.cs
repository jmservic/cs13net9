using System.Xml.Serialization; //To use XmlInclude
namespace Exercise_SerializingShapes;

[XmlInclude(typeof(Circle)), XmlInclude(typeof(Rectangle))]
public abstract class Shape
{
    public required string Colour { get; set; }

    public abstract double Area { get; }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area { get => Math.PI * Radius * Radius; }

}

public class Rectangle : Shape
{
    public double Height { get; set; }
    public double Width { get; set; }
    public override double Area { get => Height * Width; }
}
