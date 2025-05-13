using Exercise_PrimeFactorsLib;
namespace Exercise_PrimeFactorsTests;

public class PrimeFactorsTests
{
    [Theory]
    [InlineData(4, "2,2")]
    [InlineData(7, "7")]
    [InlineData(30, "5,3,2")]
    [InlineData(40, "5,2,2,2")]
    [InlineData(50, "5,5,2")]
    public void Prime_Factor_Of_Num_is_Correct(int num, string expected)
    {
        string primeFactors = PrimeFactors.GetPrimeFactors(num);
        Assert.Equal(expected, primeFactors);
    }

    [Fact]
    public void Throws_OutOfRangeException_If_Num_Negative()
    {
        int num = -1;
        Assert.Throws<ArgumentOutOfRangeException>(() => PrimeFactors.GetPrimeFactors(num));
    }
}
