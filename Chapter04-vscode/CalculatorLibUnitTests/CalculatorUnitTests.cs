using CalculatorLib;

namespace CalculatorLibUnitTests;

public class CalculatorUnitTests
{
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(2, 3, 5)]

    public void Adding_Two_Doubles(double a, double b, double expected)
    {
        // Arrange: Set up the inputs and the unit under test.
        var sut = new Calculator();

        // Act: Execute the function to test.
        double actual = sut.Add(a, b);

        // Assert: Make assertions to compare expected to actual results
        Assert.Equal(expected, actual);
    }
}
