using Xunit;
using ElipseLib;

public class IntegrationTestElipseVolumen
{
    [Theory]
    [InlineData(3, 2, 10, 188.496)]
    [InlineData(5, 5, 2, 157.080)]
    [InlineData(10, 5, 2, 314.159)]
    [InlineData(1, 1, 10, 31.416)]
    [InlineData(4, 3, 2, 75.398)]
    [InlineData(2, 1, 5, 31.416)]
    [InlineData(6, 4, 2, 150.796)]
    [InlineData(8, 2, 2, 100.531)]
    [InlineData(0.5, 0.5, 10, 7.854)]
    [InlineData(100, 50, 0.1, 1570.796)]
    [InlineData(2.5, 2.5, 4, 78.540)]
    [InlineData(12, 6, 2, 452.389)]
    [InlineData(15, 5, 1, 235.619)]
    [InlineData(7, 3, 2, 131.947)]
    [InlineData(9, 1, 10, 282.743)]
    [InlineData(20, 10, 0.5, 314.159)]
    [InlineData(0.1, 0.1, 100, 3.142)]
    [InlineData(50, 25, 2, 7853.982)]
    [InlineData(11, 7, 1, 241.903)]
    [InlineData(30, 20, 2, 3769.911)]
    public void TestIntegration(double a, double b, double h, double esperado)
    {
        double area = Elipse.Area(a, b);
        double resultado = Elipse.Volumen(area, h);
        Assert.Equal(esperado, resultado, 1);
    }
}
