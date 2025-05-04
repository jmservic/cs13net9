WriteLine("Enter a number between 0 and 255: ");
string? firstInput = ReadLine();
WriteLine("Enter another number between 0 and 255: ");
string? secondInput = ReadLine();

try 
{
    byte dividend = byte.Parse(firstInput!);
    byte divisor = byte.Parse(secondInput!);
    WriteLine(dividend);
    WriteLine(divisor);
} 
catch (FormatException)
{
    WriteLine("Input string was not in a correct format.");
}