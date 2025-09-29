
using System.Numerics;
using Exercise_NumbersAsWordsLib;

while (true)
{
    Write("Enter an integer to get its word representations: ");
    string userInput = ReadLine()!;
    BigInteger num;
    
    if (BigInteger.TryParse(userInput, out num))
    {
        WriteLine($"{num:N0}'s word representation is {num.ToWords()}");
    }
    else
    {
        WriteLine($"Was unable to parse {userInput}");
    }

    WriteLine("Press ESC to end or any key to try again.");
    ConsoleKeyInfo userKey = ReadKey();
    if (userKey.Key == ConsoleKey.Escape) return 0;
}