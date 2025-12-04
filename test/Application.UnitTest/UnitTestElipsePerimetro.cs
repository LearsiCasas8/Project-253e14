using Xunit;
using ElipseLib;

public class UnitTestElipsePerimetro
{
    [Theory]
    [InlineData(3, 2, 15.708)]
    [InlineData(5, 5, 31.416)]
    [InlineData(10, 5, 47.124)]
    [InlineData(1, 1, 6.283)]
    [InlineData(4, 3, 21.991)]
    [InlineData(2, 1, 9.425)]
    [InlineData(6, 4, 31.416)]
    [InlineData(8, 2, 31.416)]
    [InlineData(0.5, 0.5, 3.142)]
    [InlineData(100, 50, 471.239)]
    [InlineData(2.5, 2.5, 15.708)]
    [InlineData(12, 6, 56.549)]
    [InlineData(15, 5, 62.832)]
    [InlineData(7, 3, 31.416)]
    [InlineData(9, 1, 31.416)]
    [InlineData(20, 10, 94.248)]
    [InlineData(0.1, 0.1, 0.628)]
    [InlineData(50, 25, 235.619)]
    [InlineData(11, 7, 56.549)]
    [InlineData(30, 20, 157.080)]
    public void TestPerimetro(double a, double b, double esperado)
    {
        double resultado = Elipse.Perimetro(a, b);
        Assert.Equal(esperado, resultado, 3);
    }
}
