using ElipseLib;

double perimetro;
double area;
double volumen;

Console.WriteLine("Calculadora de Perímetro, Área y Volumen de un Prisma Elíptico");

Console.Write("Dame el semieje mayor a: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame el semieje menor b: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Dame la altura del prisma: ");
double altura = Convert.ToDouble(Console.ReadLine());

// Cálculos
perimetro = Elipse.CalcularPerimetro(a, b);
area = Elipse.CalcularArea(a, b);
volumen = Elipse.CalcularVolumen(area, altura);

// Resultados
Console.WriteLine();
Console.WriteLine($"Perímetro: {perimetro} cm");
Console.WriteLine($"Área: {area} cm2");
Console.WriteLine($"Volumen: {volumen} cm3");
