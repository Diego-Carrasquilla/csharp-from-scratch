
using Helloworld;

//variables 

DateOnly DateConverted = new DateOnly();
string? NameImput = null;
string? BirthdayImput = null;
bool isdateValid = false;
bool isNameValid = false;

Console.WriteLine("Hola Bienvenido al calculador de Años!");

// Validacion de nombre (ciclo While)
while (!isNameValid)
{
    Console.WriteLine("Escribe tu nombre: ");
    NameImput = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(NameImput))
    {
        isNameValid = true;
        Console.WriteLine($"Un gusto conocerte {NameImput}!");
    }
    else
    {
        Console.WriteLine("El nombre no puede estar vacío. Por favor, intenta de nuevo!!.");
    }

}
// VaLidacion de fecha (ciclo while)
while (!isdateValid)
{
    Console.WriteLine("Escribe tu fecha de nacimiento dd/mm/yy: ");
    BirthdayImput = Console.ReadLine();
    isdateValid = DateOnly.TryParse(BirthdayImput, out DateConverted);

    bool isDateValid = false;
    if (!isDateValid)
    {
        Console.WriteLine($"La fecha de nacimiento es inválida. Este dato es erróneo: {BirthdayImput}");
    }

}
var Person = new Person
{
    Name = NameImput,
    Birthday = DateConverted,
    Age = DateTime.Now.Year - DateConverted.Year
};


Console.WriteLine($"Tu Nombre {Person.Name}");
Console.WriteLine($"Tu fecha de nacimiento: {Person.Birthday}");
Console.WriteLine($"Tienes {Person.Age} Años!");

Console.WriteLine();
namespace Helloworld
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }

    }
}



