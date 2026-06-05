using Exercise_LinqQueries.EntityModels;

using NorthwindDb db = new();

//IQueryable<string?> allCities = db.Customers.Select(c => c.City).Distinct();
IQueryable<string?> allCities = (from customer in db.Customers select customer.City).Distinct();

WriteLine("A list of cities that at least one customer resides in:");
WriteLine(string.Join(", ", allCities));
WriteLine();

Write("Enter the name of a city: ");
string city = ReadLine()!;

//var customersInCity = db.Customers.Where(c => c.City!.ToLower() == city.ToLower());
var customersInCity = from customer in db.Customers where customer.City!.ToLower() == city.ToLower() select customer;


if ((customersInCity is null) || (!customersInCity.Any()))
{
    WriteLine($"No customers found in {city}.");
    return;
}

WriteLine($"There are {customersInCity.Count()} customers in {city}");
foreach (Customer customer in customersInCity)
{
    WriteLine($"    {customer.CompanyName}");
}