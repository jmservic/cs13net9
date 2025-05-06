WriteLine("Enter a number between 0 and 255: ");
string? firstInput = ReadLine();
WriteLine("Enter another number between 0 and 255: ");
string? secondInput = ReadLine();

try 
{
    byte dividend = byte.Parse(firstInput!);
    byte divisor = byte.Parse(secondInput!);
    WriteLine($"{dividend} divided by {dividend} is {dividend / divisor}.");
}
catch (FormatException)
{
    WriteLine("Input string was not in a correct format.");
}
catch (OverflowException)
{
    WriteLine("One of the inputs was outside of the range 0 and 255.");
}
catch (DivideByZeroException)
{
    WriteLine("You attempted to divide by zero!!");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} exception with the message {ex.Message}");
}
