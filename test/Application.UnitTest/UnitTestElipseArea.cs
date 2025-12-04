using Xunit;
using ElipseLib;

public class UnitTestElipseArea
{
    [Theory]
    [InlineData(3, 2, 18.850)]
    [InlineData(5, 5, 78.540)]
    [InlineData(10, 5, 157.080)]
    [InlineData(1, 1, 3.142)]
    [InlineData(4, 3, 37.699)]
    [InlineData(2, 1, 6.283)]
    [InlineData(6, 4, 75.398)]
    [InlineData(8, 2, 50.265)]
    [InlineData(0.5, 0.5, 0.785)]
    [InlineData(100, 50, 15707.963)]
    [InlineData(2.5, 2.5, 19.635)]
    [InlineData(12, 6, 226.195)]
    [InlineData(15, 5, 235.619)]
    [InlineData(7, 3, 65.973)]
    [InlineData(9, 1, 28.274)]
    [InlineData(20, 10, 628.319)]
    [InlineData(0.1, 0.1, 0.031)]
    [InlineData(50, 25, 3926.991)]
    [InlineData(11, 7, 241.903)]
    [InlineData(30, 20, 1884.956)]
    public void TestArea(double a, double b, double esperado)
    {
        double resultado = Elipse.Area(a, b);
        Assert.Equal(esperado, resultado, 3);
    }
}
