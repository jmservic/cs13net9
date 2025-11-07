//Create a List of Shapes to serialize.
using Exercise_SerializingShapes;
using System.Xml.Serialization; // To use XmlSerializer 
using System.IO;
using System.Reflection.Metadata.Ecma335;

List<Shape> listOfShapes = new()
{
    new Circle { Colour = "Red", Radius = 2.5},
    new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0},
    new Circle { Colour = "Green", Radius = 8.0},
    new Circle { Colour = "Purple", Radius = 12.3},
    new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0},
};

XmlSerializer serializerXml = new(typeof(List<Shape>));
using (FileStream fileXml = File.Open("./shapes.xml", FileMode.OpenOrCreate))
{
    serializerXml.Serialize(fileXml, listOfShapes);

    if (fileXml.CanSeek)
    {
        fileXml.Seek(0, SeekOrigin.Begin);
    }
    List<Shape>? loadedShapesXml = serializerXml.Deserialize(fileXml) as List<Shape>;
    if (loadedShapesXml is null)
    {
        WriteLine("Didn't load any shapes from xml file");
        return;
    }

    foreach (Shape item in loadedShapesXml)
    {
        WriteLine("{0} is {1} and has an area of {2:N2}",
            item.GetType().Name, item.Colour, item.Area);
    }
}