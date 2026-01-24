using Northwind.EntityModels; // To use Northwind.

//using NorthwindDb db = new();
//WriteLine($"Provider: {db.Database.ProviderName}");
// Disposes the database context.

ConfigureConsole();

/*var resultAdd = AddProduct(categoryId: 6, productName: "Bob's Burgers",
    price: 500M, stock: 72);

if (resultAdd.affected == 1)
{
    WriteLine($"Add product successful with ID: {resultAdd.productId}");
}

ListProducts(productIdsToHighlight: [ resultAdd.productId ]);*/

/*var resultUpdate = IncreaseProductPrice(
    productNameStartsWith: "Bob", amount: 20M
);

if (resultUpdate.affected == 1)
{
    WriteLine($"Increase price success forID: {resultUpdate.productId}.");
}

ListProducts(productIdsToHighlight: new[] { resultUpdate.productId }); */

/*WriteLine("About to delete all products whose name starts with Bob.");
Write("Press Enter to continue or any other key to exit: ");
if (ReadKey(intercept: true).Key == ConsoleKey.Enter)
{
    Write(Environment.NewLine);
    int deleted = DeleteProducts(productNameStartsWith: "Bob");
    WriteLine($"{deleted} product(s) were deleted.");
} else
{
    Write(Environment.NewLine);
    WriteLine("Delete was canceled.");
} */

/*var resultUpdateBetter = IncreaseProductPricesBetter(
    productNameStartsWith: "Bob", amount: 20M
);

if (resultUpdateBetter.affected > 0)
{
    WriteLine("Increase product price successful.");
}

ListProducts(productIdsToHighlight: resultUpdateBetter.productIds); */

WriteLine("About to delete all products whose name starts with Bob.");
Write("Press Enter to continue or any other key to exit: ");
if (ReadKey(intercept: true).Key == ConsoleKey.Enter)
{
    int deleted = DeleteProductsBetter(productNameStartsWith: "Bob");
    WriteLine($"{deleted} product(s) were deleted.");
} else
{
    WriteLine("Delete was canceled.");
}

//LazyLoadingWithNoTracking();

//QueryingCategories();

//FilteredIncludes();

//QueryingProducts();

//GettingOneProduct();

//QueryingWithLike();

//GetProductUsingSql();