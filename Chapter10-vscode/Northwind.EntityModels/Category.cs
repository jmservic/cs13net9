using System.ComponentModel.DataAnnotations.Schema; // To use [Column]
using System.Xml.Serialization;
using System.Text.Json.Serialization;
namespace Northwind.EntityModels;
[XmlInclude(typeof(HashSet<Product>))]
public class Category
{
    // These properties map to columsn in the database.
    public int CategoryId { get; set; } // The primary key.

    public string CategoryName { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string? Description { get; set; }

    // Defines a navigation property for related rows.
    [XmlIgnore]
    [JsonIgnore]
    public virtual ICollection<Product> Products { get; set; }
    // To enable developers to add products to a Category, we must initialize the navigation property to an empty collection.
    // This also avoids an exception if we get a member like Count.
    = new HashSet<Product>();


}
