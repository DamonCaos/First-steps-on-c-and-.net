using System;

class Program
{
    static void Main()
    {
        // Opcional: para que salgan bien tildes y ñ en algunas consolas de Windows
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string nombre = PedirNombre();
        DateTime nacimiento = PedirFechaNacimiento();
        int edad = CalcularEdad(nacimiento, DateTime.Now);
        MostrarResultado(nombre, nacimiento, edad);
    }

    // --- Funciones ---

    static string PedirNombre()
    {
        while (true)
        {
            Console.Write("¡Hola! ¿Cómo te llamas? ");
            string nombre = Console.ReadLine()?.Trim() ?? "";
            if (!string.IsNullOrWhiteSpace(nombre)) return nombre;
            Console.WriteLine("El nombre no puede estar vacío. Inténtalo de nuevo.\n");
        }
    }

    static int PedirEnteroEnRango(string mensaje, int min, int max)
    {
        while (true)
        {
            Console.Write(mensaje);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int valor) && valor >= min && valor <= max)
            {
                return valor;
            }
            Console.WriteLine($"Valor inválido. Debe ser un número entre {min} y {max}. Inténtalo de nuevo.\n");
        }
    }

    static DateTime PedirFechaNacimiento()
    {
        int anioActual = DateTime.Now.Year;

        int anio = PedirEnteroEnRango($"¿En qué año naciste? (1900-{anioActual}): ", 1900, anioActual);
        int mes  = PedirEnteroEnRango("¿En qué mes naciste? (1-12): ", 1, 12);

        while (true)
        {
            int dia = PedirEnteroEnRango("¿En qué día naciste? (1-31): ", 1, 31);
            try
            {
                var fecha = new DateTime(anio, mes, dia);

                if (fecha > DateTime.Now)
                {
                    Console.WriteLine("La fecha no puede ser futura. Inténtalo de nuevo.\n");
                    continue; // volver a pedir el día
                }

                return fecha;
            }
            catch
            {
                Console.WriteLine("La combinación día/mes/año no es válida (p. ej., 31/02). Inténtalo de nuevo.\n");
            }
        }
    }

    static int CalcularEdad(DateTime nacimiento, DateTime hoy)
    {
        int edad = hoy.Year - nacimiento.Year;
        if (hoy < nacimiento.AddYears(edad)) edad--;
        return edad;
    }

    static void MostrarResultado(string nombre, DateTime nacimiento, int edad)
    {
        Console.WriteLine($"\n¡Hola {nombre}! Naciste el {nacimiento:dd/MM/yyyy} y tienes {edad} años.");
    }
}
