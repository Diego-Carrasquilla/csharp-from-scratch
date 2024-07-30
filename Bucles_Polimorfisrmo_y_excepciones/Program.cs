
var Circ = new Circulo();

Circ.Radio = 20;
var result_Area = Circ.Area();
var result_Perim = Circ.Perimetro();

Console.WriteLine($"EL area es: {result_Area} y el perimetro es: {result_Perim} el nuevo radio es {Circ.Add10()}");

int prev = 0, next = 1, sum;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(prev);
    sum = prev + next;
    prev = next;
    next = sum;

}
try
{
    Console.WriteLine("Numero a Dividr: ");
    double n =double.Parse(Console.ReadLine());
    Console.WriteLine("Divisor: ");
    double divisor = double.Parse(Console.ReadLine());
    if (divisor == 0)
    {
        throw new DivideByZeroException();
    }

    Console.WriteLine($"Resultado: {n / divisor}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se Puede Dividir por 0!");
}
catch (Exception)
{
    Console.WriteLine("Error Desconocido.");
}

// abstract class Figura
// {
//     public abstract double Area();
//     public abstract double Perimetro();
// }

interface IExtraCalculations
{
    public double Add10();
}

interface IFigura
{
    public abstract double Area();
    public abstract double Perimetro();
}


class Circulo : IFigura, IExtraCalculations
{
    public double Radio { get; set; }
    public double Area() => Math.PI * Math.Pow(Radio, 2);
    public double Perimetro() => 2 * Math.PI * Radio;
    public double Add10()
    {
        return Radio + 10;
    }

}