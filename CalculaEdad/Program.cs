using System;

class Program
{
    static void Main()
    {
        // Saludo y petición de datos
        Console.WriteLine("¡Hola! ¿Cómo te llamas?");
        string nombre = Console.ReadLine();

        Console.WriteLine("¿En qué año naciste?");
        string input = Console.ReadLine();

        Console.WriteLine("¿En qué mes naciste? (1-12)");
        string mesInput = Console.ReadLine();

        Console.WriteLine("¿Qué día naciste? (1-31)");
        string diaInput = Console.ReadLine();

        // Convertir la entrada a número y validar
        if (int.TryParse(input, out int anioNacimiento) &&
            int.TryParse(mesInput, out int mesNacimiento) &&
            int.TryParse(diaInput, out int diaNacimiento))
        {
            try
            {
                // Crear fecha de nacimiento
                DateTime nacimiento = new DateTime(anioNacimiento, mesNacimiento, diaNacimiento);
                DateTime hoy = DateTime.Now;

                // Calcular edad
                int edad = hoy.Year - nacimiento.Year;
                if (hoy < nacimiento.AddYears(edad))
                {
                    edad--;
                }

                // Mostrar resultado
                Console.WriteLine($"\n¡Hola {nombre}! Naciste el {diaNacimiento}/{mesNacimiento}/{anioNacimiento}, " +
                                  $"así que tienes {edad} años.");
            }
            catch (Exception)
            {
                Console.WriteLine("La fecha ingresada no es válida. Por favor, inténtalo de nuevo.");
            }
        }
        else
        {
            Console.WriteLine("Alguno de los valores introducidos no es válido, inténtalo de nuevo, por favor.");
        }
    }
}
