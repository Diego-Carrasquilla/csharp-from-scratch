using System;
//Notaran que del ejercicio 1 al 10, son distintos, pues en el video al entrar al archivo de challenges, aparecian unos nombres de ejercicios de los que me guie,
//luego note que en el video iba cambiando los ejercicios mendiante avanzaba, muchos son iguales pero algunos son distintos, aun asi igual de interesantes
//no los cambie puesto que ya los tenia hechos, espero lo entiendan, muchas gracias!! :)
namespace Challenges
{
    public static class Ejercicios
    {
        public static void Ejercicio1() // Determinar si un numero es positivo negativo o cero
        {
            double numero = Menu.GetValidNumber("Ingrese un  número:");

            if (numero > 0)
            {
                Console.WriteLine("El numero es positivo"); //Operaciones basicas entre dos numeros.
            }
            else if (numero < 0)
            {
                Console.WriteLine("El numero es negativo");
            }
            else
            {
                Console.WriteLine("El numero es cero");
            }
        }

        public static void Ejercicio2()
        {
            double numero1 = Menu.GetValidNumber("Ingrese el primer número:");
            double numero2 = Menu.GetValidNumber("Ingrese el segundo número:");

            Console.WriteLine($"Suma: {numero1 + numero2}");
            Console.WriteLine($"Resta: {numero1 - numero2}");
            Console.WriteLine($"Multiplicación: {numero1 * numero2}");

            if (numero2 != 0)
            {
                Console.WriteLine($"División: {numero1 / numero2}");
            }
            else
            {
                Console.WriteLine("División: Indeterminado (no se puede dividir por cero)");
            }
        }

        public static void Ejercicio3()//Determinar si un año es bisiesto.
        {
            double yearDouble = Menu.GetValidNumber("Ingrese el Año:");//utilizamos get valid para que nos de un numero valido
            int year = (int)yearDouble;// lo pasamos a entero para poderlo operar con %

            string resultado = Menu.EsBisiesto(year) ? "SI es Bisiesto" : "NO es Bisieto";//verificamos si es Bisiesto
            Console.WriteLine($"{year} {resultado}.");
        }

        public static void Ejercicio4()//Calcular el area y el perimetro de un rectangulo.
        {
            double Base = Menu.GetValidNumber("ingrese la Base del rectangulo: ");
            double Altura = Menu.GetValidNumber("ingrese la Altura del rectangulo: ");

            double Area() => Base * Altura;
            double Perimetro() => 2 * (Base + Altura);

            Console.WriteLine($"El area es: {Area()}");
            Console.WriteLine($"El perímetro es: {Perimetro()}");
        }

        public static void Ejercicio5()//Encontrar el mayor de 3 numeros.
        {
            double num1 = Menu.GetValidNumber("Ingrese el primer numero: ");
            double num2 = Menu.GetValidNumber("Ingrese el segundo número: ");
            double num3 = Menu.GetValidNumber("Ingrese el tercer número: ");
            double max = Math.Max(num1, Math.Max(num2, num3));
            Console.WriteLine($"El mayor de los tres números es: {max}");
        }

        public static void Ejercicio6()//Calcular el factorial de un numero
        {
            double factDouble = Menu.GetValidNumber("Ingrese Numero Para Calcular su Factorial:");//utilizamos get valid para que nos de un numero valido
            int fact = (int)factDouble;// lo pasamos a entero para poderlo operar

            int n = fact;
            if (n < 0)
            {
                throw new ArgumentException("El numero no puede ser negativo.");
            }
            if (n == 0 || n == 1)
            {
                Console.WriteLine($"El factorial de {fact} es: 1");
                return;
            }

            double factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"El factorial de {fact} es: {factorial}");

        }

        public static void Ejercicio7()//Realizar una division.
        {
            // Solicitar al usuario el dividendo

            double dividend = Menu.GetValidNumber("Ingrese el Dividendo");

            // Solicitar al usuario el divisor
            double divisor = Menu.GetValidNumber("Ingrese el Divisor"); ;
            try
            {
                // Comprobar si el divisor es cero
                if (divisor == 0)
                {
                    throw new DivideByZeroException("El divisor no puede ser cero.");
                }

                // Realizar la división
                double result = dividend / divisor;

                // Mostrar el resultado
                Console.WriteLine($"El resultado de la división es: {result}");
            }
            catch (DivideByZeroException ex)
            {
                // Manejar la excepción de división por cero
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public static void Ejercicio8()//Sumar numeros impares entre 1 y 100. 
        {
            int suma = 0;
            for (int i = 1; i <= 100; i += 2)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de los números impares entre 1 y 100 es: {suma}");
        }

        public static void Ejercicio9()// Sumar fracciones
        {
            Console.WriteLine("Suma de Fracciones");

            int num1 = (int)Menu.GetValidNumber("Ingrese el numerador de la primera fraccion: ");
            int den1 = (int)Menu.GetValidNumber("Ingrese el denominador de la primera fraccion: ");

            int num2 = (int)Menu.GetValidNumber("Ingrese el numerador de la segunda fraccion: ");
            int den2 = (int)Menu.GetValidNumber("Ingrese el denominador de la segunda fraccion: ");

            int numResult = num1 * den2 + num2 * den1;
            int denResult = den1 * den2;

            Console.WriteLine($"El resultado de la suma es: {numResult}/{denResult}");
        }
        public static void Ejercicio10()// Invertir palabra
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            char[] arrayPalabra = palabra.ToCharArray();
            Array.Reverse(arrayPalabra);
            string palabraInvertida = new string(arrayPalabra);
            Console.WriteLine($"La palabra invertida es: {palabraInvertida}");
        }
        public static void Ejercicio11()//solicitar alm usuario 3 numeros y dar el promedio entre ellos
        {
            double num1 = Menu.GetValidNumber("Ingrese el primer número: ");
            double num2 = Menu.GetValidNumber("Ingrese el segundo número: ");
            double num3 = Menu.GetValidNumber("Ingrese el tercer número: ");

            double promedio = (num1 + num2 + num3) / 3;

            Console.WriteLine($"El promedio de {num1}, {num2}, y {num3} es: {promedio}");
        }

        public static void Ejercicio12()//solitar al usuario 5 numeros y mostrar el numero mas grande de los 5

        {
            double num1 = Menu.GetValidNumber("Ingrese el primer numero: ");
            double num2 = Menu.GetValidNumber("Ingrese el segundo numero: ");
            double num3 = Menu.GetValidNumber("Ingrese el tercer numero: ");
            double num4 = Menu.GetValidNumber("Ingrese el cuarto numero: ");
            double num5 = Menu.GetValidNumber("Ingrese el quinto numero: ");

            double maxNum = Math.Max(num1, Math.Max(num2, Math.Max(num3, Math.Max(num4, num5))));

            Console.WriteLine($"El número más grande entre {num1}, {num2}, {num3}, {num4} y {num5} es: {maxNum}");
        }

        public static void Ejercicio13()//ver si es un palindromo
        {
            Console.WriteLine("Ingrese una palabra:");
            string palabra = Console.ReadLine();
            string palabraInvertida = new string(palabra.Reverse().ToArray());

            if (palabra.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"La palabra '{palabra}' es un palindromo.");
            }
            else
            {
                Console.WriteLine($"La palabra '{palabra}' no es un palindromo.");
            }
        }

        public static void Ejercicio14()// Par o Impar
        {
            int numero = (int)Menu.GetValidNumber("Ingrese un número:");

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El numero {numero} es par.");
            }
            else
            {
                Console.WriteLine($"El numero {numero} es impar.");
            }
        }
        public static void Ejercicio15()//Ver si esta en rango del 0 al 10 
        {
            double numero = Menu.GetValidNumber("Ingrese un número:");

            if (numero >= 1 && numero <= 10)
            {
                Console.WriteLine($"El numero {numero} esta en el rango del 1 al 10.");
            }
            else
            {
                Console.WriteLine($"El numero {numero} no esta en el rango del 1 al 10.");
            }

        }





    }


}
