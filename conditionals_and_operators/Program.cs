using System;

namespace ConditionalsAndOperators
{
    class Program
    {
        static void Main()
        {
            /* Conditionals */

            // Console.WriteLine("Ingrese un número: ");

            // int num = int.Parse(Console.ReadLine());

            // if (num > 0) Console.WriteLine("Positivo");

            // else if (num < 0) Console.WriteLine("Negativo");
            
            // else Console.WriteLine("Es cero!");
  
            /* End Conditionals */

            /* Operators */
            Console.WriteLine("Ingrese el primer número: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número: ");
            double b = double.Parse(Console.ReadLine());

            const string Indeterminado = "Indeterminado";

           
            Console.WriteLine($"Suma: {a + b}");
            Console.WriteLine($"Resta: {a - b}");
            Console.WriteLine($"Multiplicación: {a * b}");
            Console.WriteLine($"División: {(b != 0 ? a / b : Indeterminado)}");
            /* End Operators */
        }
    }
}
