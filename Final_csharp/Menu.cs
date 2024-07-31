
using System;

namespace Challenges
{
    public class Menu
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("Ingrese su nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}, bienvenido a los desafíos de programación!");

            while (true)
            {
                Console.WriteLine("Seleccione el ejercicio que desea ejecutar o escriba 'q' o 'exit' para salir:");
                Console.WriteLine("1. Determinar si un numero es positivo negativo o cero");
                Console.WriteLine("2. Operaciones basicas entre dos numeros.");
                Console.WriteLine("3. Determinar si un año es bisiesto.");
                Console.WriteLine("4. Calcular el area y el perimetro de un rectangulo.");
                Console.WriteLine("5. Encontrar el mayor de 3 numeros.");
                Console.WriteLine("6. Calcular el factorial de un numero.");
                Console.WriteLine("7. Realizar una division.");
                Console.WriteLine("8. Sumar numeros impares entre 1 y 100.");
                Console.WriteLine("9. Operaciones con fracciones.");
                Console.WriteLine("10.Palabra en orden inverso");
                Console.WriteLine("11.solicitar alm usuario 3 numeros y dar el promedio entre ellos");
                Console.WriteLine("12.solitar al usuario 5 numeros y mostrar el numero mas grande de los 5");
                Console.WriteLine("13.Ver si es un palindromo");
                Console.WriteLine("14.Ver si un numero es par o impar");
                Console.WriteLine("15.Ver si un numero esta en rango del 0 al 10");

                string opcion = Console.ReadLine();

                if (opcion.ToLower() == "q" || opcion.ToLower() == "exit")
                {
                    Console.WriteLine("Gracias por usar el programa. ¡Hasta luego!");
                    break;
                }

                switch (opcion)
                {
                    case "1":
                        Ejercicios.Ejercicio1();
                        break;
                    case "2":
                        Ejercicios.Ejercicio2();
                        break;
                    case "3":
                        Ejercicios.Ejercicio3();
                        break;
                    case "4":
                        Ejercicios.Ejercicio4();
                        break;
                    case "5":
                        Ejercicios.Ejercicio5();
                        break;
                    case "6":
                        Ejercicios.Ejercicio6();
                        break;
                    case "7":
                        Ejercicios.Ejercicio7();
                        break;
                    case "8":
                        Ejercicios.Ejercicio8();
                        break;
                    case "9":
                        Ejercicios.Ejercicio9();
                        break;
                    case "10":
                        Ejercicios.Ejercicio10();
                        break;
                    case "11":
                        Ejercicios.Ejercicio11();
                        break;
                    case "12":
                        Ejercicios.Ejercicio12();
                        break;
                    case "13":
                        Ejercicios.Ejercicio13();
                        break;
                    
                    case "15":
                        Ejercicios.Ejercicio15();
                        break;

                    default:
                        Console.WriteLine("Opción no valida. Por favor, intente de nuevo.");
                        break;
                }
            }
        }

        public static double GetValidNumber(string message)
        {
            double number;
            bool isValid;
            do
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                isValid = double.TryParse(input, out number);
                if (!isValid)
                {
                    Console.WriteLine("Entrada invalida, Por favor, ingrese un numero valido.");
                }
            } while (!isValid);

            return number;
        }

        public static bool EsBisiesto(int year)
        //Metodo para ver si un año es biciesto, formula sacada de: 
        //https://learn.microsoft.com/es-es/office/troubleshoot/excel/determine-a-leap-year
        {
            return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
        }


    }
}