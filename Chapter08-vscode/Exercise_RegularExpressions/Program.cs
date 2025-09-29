using System.Text.RegularExpressions; //To use Regex.

WriteLine("The default regular expression checks for at least one digit.");

while (true)
{
    string regExp = @"\d+";
    Write("Enter a regular expression (or press ENTER to use the default): ");
    string userInput = ReadLine()!;
    if (userInput != String.Empty)
    {
        regExp = userInput;
    }
    Write("Enter some input: ");
    userInput = ReadLine()!;
    WriteLine($"{userInput} matches {regExp}? {Regex.IsMatch(userInput, regExp)}");
    Write("Press ESC to end or any key to try again.");
    ConsoleKeyInfo userKey = ReadKey();
    if (userKey.Key == ConsoleKey.Escape) return 0;
}