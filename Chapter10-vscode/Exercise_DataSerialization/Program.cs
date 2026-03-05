using Northwind.EntityModels;
using System.Text.Json; // To use JsonSerializer.
using System.Xml.Serialization; // To use XmlSerializer.
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary; // To use BinaryFormatter

using NorthwindDb db = new();

List<Category>? categories = db.Categories?.ToList();
List<Product>? products = db.Products?.ToList();

string jsonCatFile = Path.Combine(Environment.CurrentDirectory, "serialize_cat.json");
string jsonProdFile = Path.Combine(Environment.CurrentDirectory, "serialize_prod.json");
string xmlCatFile = Path.Combine(Environment.CurrentDirectory, "serialize_cat.xml");
string xmlProdFile = Path.Combine(Environment.CurrentDirectory, "serialize_prod.xml");

if (File.Exists(jsonCatFile)) File.Delete(jsonCatFile);
if (File.Exists(jsonProdFile)) File.Delete(jsonProdFile);
if (File.Exists(xmlCatFile)) File.Delete(xmlCatFile);
if (File.Exists(xmlProdFile)) File.Delete(xmlProdFile);



using FileStream jsonCatStream = File.Create(jsonCatFile);
using FileStream jsonProdStream = File.Create(jsonProdFile);
using FileStream xmlCatStream = File.Create(xmlCatFile);
using FileStream xmlProdStream = File.Create(xmlProdFile);


XmlSerializer xmlSerializer = new(typeof(List<Category>));

JsonSerializer.Serialize(jsonCatStream, categories);
JsonSerializer.Serialize(jsonProdStream, products);

xmlSerializer.Serialize(xmlCatStream, categories);

xmlSerializer = new(typeof(List<Product>));
xmlSerializer.Serialize(xmlProdStream, products);

FileInfo jsonCatFileInfo = new(jsonCatFile);
FileInfo jsonProdFileInfo = new(jsonProdFile);
FileInfo xmlCatFileInfo = new(xmlCatFile);
FileInfo xmlProdFileInfo = new(xmlProdFile);

WriteLine($"Json file sizes: {jsonCatFileInfo.Length + jsonProdFileInfo.Length} bytes");
WriteLine($"Xml file sizes: {xmlCatFileInfo.Length + xmlProdFileInfo.Length} bytes");
