namespace Helloworld
{
    class Program
    {
        static void Main()
        {
            /*Variables*/
            DateOnly DateConverted = new DateOnly();
            string NameImput;
            string BirthdayImput;

            Console.WriteLine("Hola Bienvenido al calculador de Años!");
            Console.WriteLine("Escribe tu nombre: ");
            NameImput = Console.ReadLine();

            Console.WriteLine($"Un gusto conocerte {NameImput}!");
            Console.WriteLine("Escribe tu fecha de nacimiento dd/mm/yy: ");
            BirthdayImput = Console.ReadLine();
            bool isdateValid = DateOnly.TryParse(BirthdayImput, out DateConverted);
            if (isdateValid == false) Console.WriteLine($"La fecha de nacimiento es invalida, este dato es erroneo {BirthdayImput}");
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


        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateOnly Birthday { get; set; }

    }
}



