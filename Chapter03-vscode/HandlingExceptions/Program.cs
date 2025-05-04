WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();

try 
{
    int age = int.Parse(input!);
    WriteLine($"You are {age} years old.");
}
catch (OverflowException)
{
    WriteLine("Your age is a valid nmber format but it is either too big or small.");
}
catch (FormatException)
{
    WriteLine("The age you entered is not a valid number format.");
} 
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After parsing");

#region Checking for overflow
checked 
{
    try
    {
        int x = int.MaxValue - 1;
        WriteLine($"Initial value: {x}");
        for(int i = 0; i < 3; ++i)
        {
            x++;
            WriteLine($"After incrementing: {x}");
        }
    }
    catch (OverflowException)
    {
        WriteLine("The code overflowed but I caught the exception.");
    }
}
#endregion

#region Disabling compiler overflow checks with the unchecked statement
unchecked 
{
    int y = int.MaxValue + 1;
    WriteLine($"Initial value: {y}");
    WriteLine($"After decrementing: {--y}");
    WriteLine($"After decrementing: {--y}");

}
#endregion