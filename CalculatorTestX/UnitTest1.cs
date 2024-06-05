namespace CalculatorTestX;
using CalculatorTesting;
public class UnitTest1
{
    private Calculator _calculator;

    public UnitTest1()
    {
        _calculator = new();
    }
    [Fact]
    public void Test1()
    {
        // Arrange
        int a = 3, b = 2;
        int expectation = 5;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(expectation, result);

    }

    [Theory]
    [InlineData(2,2,4)]
    [InlineData(3,3,6)]
    public void Add_ReturnCorrectValue_UsingTestCase(int a, int b, int expectation)
    {
        // Act
        int result = _calculator.Add(a, b);
        // Assert
        Assert.Equal(expectation, result);
    }
}