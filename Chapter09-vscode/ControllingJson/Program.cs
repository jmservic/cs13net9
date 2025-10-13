using Packt.Shared; // To use Book.
using System.Text.Json; // To use JsonSerializer.

Book csharpBook = new(title: "C# 13 and .NET 9 - Modern Cross_Platform Development Fundamentals")
{
    Author = "Mark J Price",
    PublishDate = new(year: 2024, month: 11, day: 12),
    Pages = 823,
    Created = DateTimeOffset.UtcNow,
};

JsonSerializerOptions options = new()
{
    IncludeFields = true,
    PropertyNameCaseInsensitive = true,
    WriteIndented = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};

string path = Combine(CurrentDirectory, "book.json");

using (Stream filestream = File.Create(path))
{
    JsonSerializer.Serialize(utf8Json: filestream, value: csharpBook, options);
}

WriteLine("**** File Info ****");
WriteLine($"File: {GetFileName(path)}");
WriteLine($"Path: {GetDirectoryName(path)}");
WriteLine($"Size: {new FileInfo(path).Length:N0} bytes.");
WriteLine("/------------------");
WriteLine(File.ReadAllText(path));
WriteLine("------------------/");