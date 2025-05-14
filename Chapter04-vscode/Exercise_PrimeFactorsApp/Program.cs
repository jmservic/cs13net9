using Exercise_PrimeFactorsLib;
WriteLine("Welcome to the Prime factor generator!");
string? response = "";
do 
{
    try 
    {
        Write("Enter a number to get its prime factors or q to quit: ");
        response = ReadLine();
        int num = int.Parse(response!);
        Console.WriteLine($"The prime factors of {num} are {PrimeFactors.GetPrimeFactors(num)}");
    } catch (FormatException ex) when (response != "q") 
    {
        Console.WriteLine(ex.Message);
    } catch (FormatException)
    {
        //do nothing!!
    }
} while(response != "q");