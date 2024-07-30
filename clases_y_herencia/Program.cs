
/* Clases */
using ClasesYHerencia;

internal class Program
{
    private static void Main(string[] args)
    {
        var rect = new Rectangulo();
        rect.Base = GetValidNumber("ingrese la Base del rectangulo: ");
        rect.Altura = GetValidNumber("ingrese la Altura del rectangulo: ");

        Console.WriteLine($"El área es: {rect.Area()}");
        Console.WriteLine($"El perímetro es: {rect.Perimetro()}");


        var cuadr = new Cuadrado();
        cuadr.Lado = GetValidNumber("ingrese el Lado del Cuadrado: ");

        Console.WriteLine($"El área es: {cuadr.Area()}");
        Console.WriteLine($"El perímetro es: {cuadr.Perimetro()}");
        Console.WriteLine($"El Lado es: {cuadr.Lado}");

        static double GetValidNumber(string message)
        {
            double number=0;
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine(); 

                isValid = double.TryParse(input, out number);
                if (!isValid)
                {
                    Console.WriteLine("La entrada no es valida, por favor, ingrese un numero valido!");
                }
            }
            return number;

        }
    }
}

namespace ClasesYHerencia
{
    /* End Clases */

    class Rectangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public double Area() => Base * Altura;

        public double Perimetro() => 2 * Base + 2 * Altura;
    }
}

class Cuadrado : Rectangulo
{
    public double Lado
    {
        set { Base = value; Altura = value; }
        get { return Base; }

    }

}