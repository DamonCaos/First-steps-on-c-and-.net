using System;

class Program
{
    static void Main()
    {
        string nombre = PedirNombre();
        DateTime nacimiento = PedirFechaNacimiento();
        int edad = CalcularEdad(nacimiento, DateTime.Now);
        MostrarResultado(nombre, nacimiento, edad);
    }

    //Funciones

    static string PedirNombre()
    {
        while (true)
        {
            Console.Write("Hola, ¡Como te llamas?");
            string nombre = console.ReadLine()?.Trim() ?? "";
            if (!string.IsNullOrWhiteSpace(nombre)) return PedirNombre;
            Console.WriteLine("El nombre no puede estar vacio, intentelo de nuevo.\n");

        }
    }

    static int PedirEnteroEnRango(string mensaje, int min, inst max)
    {
        while (true)
        {
            Console.Write(mensaje);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int valor) && valor >= min && valor <= max)
            {
                return valor;
            }
            Console.WriteLine($"Valor invalido, debe ser un numero entre {min} y {max}. Intente de nuevo.\n");
        }
    }

    static DateTime PedirFechaNacimiento()
    {
        int anioActual = DateTime.Now.Year;

        int anio = PedirEnteroEnRango("¿En que año naciste? ", 1900.anioActual);
    }
}
