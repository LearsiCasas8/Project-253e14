namespace ElipseLib;

public static class Elipse
{
    public static double Perimetro(double a, double b)
        => Math.PI * (a + b);

    public static double Area(double a, double b)
        => Math.PI * a * b;

    public static double Volumen(double area, double hPrisma)
        => area * hPrisma;

    public static double CalcularVolumen(double area, double altura)
    {
        throw new NotImplementedException();
    }

    public static double CalcularPerimetro(double a, double b)
    {
        throw new NotImplementedException();
    }

    public static double CalcularArea(double a, double b)
    {
        throw new NotImplementedException();
    }
}

