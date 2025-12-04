using Xunit;
using ElipseLib;

public class UnitTestElipseVolumen
{
    [Theory]
    [InlineData(18.850, 10, 188.500)]
    [InlineData(78.540, 2, 157.080)]
    [InlineData(157.080, 2, 314.160)]
    [InlineData(3.142, 10, 31.420)]
    [InlineData(37.699, 2, 75.398)]
    [InlineData(6.283, 5, 31.415)]
    [InlineData(75.398, 2, 150.796)]
    [InlineData(50.265, 2, 100.530)]
    [InlineData(0.785, 10, 7.850)]
    [InlineData(15707.963, 0.1, 1570.796)]
    [InlineData(19.635, 4, 78.540)]
    [InlineData(226.195, 2, 452.390)]
    [InlineData(235.619, 1, 235.619)]
    [InlineData(65.973, 2, 131.946)]
    [InlineData(28.274, 10, 282.740)]
    [InlineData(628.319, 0.5, 314.160)]
    [InlineData(0.031, 100, 3.100)]
    [InlineData(3926.991, 2, 7853.982)]
    [InlineData(241.903, 1, 241.903)]
    [InlineData(1884.956, 2, 3769.912)]
    public void TestVolumen(double area, double h, double esperado)
    {
        double resultado = Elipse.Volumen(area, h);
        Assert.Equal(esperado, resultado, 3);
    }
}
