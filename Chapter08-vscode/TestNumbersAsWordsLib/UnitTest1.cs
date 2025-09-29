using System.Numerics;
using Exercise_NumbersAsWordsLib;

namespace TestNumbersAsWordsLib;

public class TestNumbersAsWordsLib
{
    [Theory]
    [InlineData(["18456002032011000007", "eighteen quintillion, four hundred and fifty-six quadrillion, two trillion, thirty-two billion, eleven million, and seven"])]
    [InlineData(["18000000", "eighteen million"])]
    [InlineData(["57", "fifty-seven"])]
    [InlineData(["0", "zero"])]
    [InlineData(["19", "nineteen"])]
    public void BigIntegerHasCorrectStringRepresentation(string strRepresentation, string wordRepresentation)
    {
        BigInteger sut = BigInteger.Parse(strRepresentation);
        Assert.Equal(sut.ToWords(), wordRepresentation);
    }
}
