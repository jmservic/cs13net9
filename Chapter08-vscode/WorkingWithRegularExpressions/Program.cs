using System.Text.RegularExpressions; // To use Regex.

Write("Enter your age: ");
string input = ReadLine()!; // Null-forgiving operator.
Regex ageChecker = DigitsOnly;
WriteLine(ageChecker.IsMatch(input) ? "Thank you!" : 
    $"This is not a valid age: {input}");


#region Splitting a complex comma-separated string
string films = """
"Monsters, Inc.", "I, Tonya", "Lock, Stock and Two Smoking Barrels"
""";

WriteLine(films);

string[] filmsDumb = films.Split(',');

WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
{
    WriteLine($"    {film}");
}

Regex csv = CommaSeparator;

MatchCollection filmsSmart = csv.Matches(films);

WriteLine("Splitting with regular expression:");
foreach (Match film in filmsSmart)
{
    WriteLine($"    {film.Groups[2].Value}");
}
#endregion