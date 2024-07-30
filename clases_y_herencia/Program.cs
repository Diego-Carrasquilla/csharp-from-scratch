
/* Clases */
using ClasesYHerencia;

namespace ClasesYHerencia
{
    class Program
    {
        static void Main()
        {

            var rect = new Rectangulo();
            rect.Base = 20;
            rect.Altura = 40;

            Console.WriteLine($"El área es: {rect.Area()}");
            Console.WriteLine($"El perímetro es: {rect.Perimetro()}");


            var cuadr = new Cuadrado();
            cuadr.Lado = 20;
            
            Console.WriteLine($"El área es: {cuadr.Area()}");
            Console.WriteLine($"El perímetro es: {cuadr.Perimetro()}");
            Console.WriteLine($"El Lado es: {cuadr.Lado}");
        }
    }
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










