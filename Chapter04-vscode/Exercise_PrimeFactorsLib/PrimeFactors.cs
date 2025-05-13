namespace Exercise_PrimeFactorsLib;

public static class PrimeFactors
{
    public static string GetPrimeFactors(int num)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(num, nameof(num));
        
        for (int i = num - 1; i > 1; --i)
        {
            if (num % i == 0)
            {
                int op1 = i;
                int op2 = num / i;
                return GetPrimeFactors(op1) + "," + GetPrimeFactors(op2);
            }
        }
        return num.ToString();
    }

}
