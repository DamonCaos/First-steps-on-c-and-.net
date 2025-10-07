// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Saludo y peticion de datos
        Console.WriteLine("¡Hola! ¿Cómo te llamas?");
        string nombre = Console.ReadLine();

        Console.WriteLine("¿En qué Año naciste?");
        string input = Console.ReadLine();

        // Convertir la entrada a numero
        int anioNacimiento = int.Parse(input);

        // Calcula la edad
        int anioActual = DateTime.Now.Year;
        int edad = anioActual - anioNacimiento;

        Console.WriteLine($"\nEncantado, {nombre}. Tienes aproximadamente {edad} años.");
    }
}