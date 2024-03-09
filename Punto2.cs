using System;

class Program
{
    static void Main()
    {
        int acumuladorNiño = 0;
        int acumuladorJoven = 0;
        int acumuladorAdulto = 0;
        int acumuladorViejo = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese la edad de la persona:");
            int edad;
            while (!int.TryParse(Console.ReadLine(), out edad) || edad <= 0)
            {
                Console.WriteLine("Edad no válida. Ingrese una edad válida:");
            }

            if (edad <= 12)
            {
                Console.WriteLine("Ingrese el peso del niño:");
                int pesoNiño;
                while (!int.TryParse(Console.ReadLine(), out pesoNiño))
                {
                    Console.WriteLine("Peso no válido. Ingrese un peso válido:");
                }
                acumuladorNiño += pesoNiño;
            }
            else if (edad <= 29)
            {
                Console.WriteLine("Ingrese el peso del joven:");
                int pesoJoven;
                while (!int.TryParse(Console.ReadLine(), out pesoJoven))
                {
                    Console.WriteLine("Peso no válido. Ingrese un peso válido:");
                }
                acumuladorJoven += pesoJoven;
            }
            else if (edad <= 59)
            {
                Console.WriteLine("Ingrese el peso del adulto:");
                int pesoAdulto;
                while (!int.TryParse(Console.ReadLine(), out pesoAdulto))
                {
                    Console.WriteLine("Peso no válido. Ingrese un peso válido:");
                }
                acumuladorAdulto += pesoAdulto;
            }
            else if (edad > 60)
            {
                Console.WriteLine("Ingrese el peso del viejo:");
                int pesoViejo;
                while (!int.TryParse(Console.ReadLine(), out pesoViejo))
                {
                    Console.WriteLine("Peso no válido. Ingrese un peso válido:");
                }
                acumuladorViejo += pesoViejo;
            }
            else
            {
                Console.WriteLine("Error: Edad no válida");
                i--;
            }
        }

        Console.WriteLine("Resultados:");
        Console.WriteLine($"Promedio de peso de niños: {acumuladorNiño / 5.0}");
        Console.WriteLine($"Promedio de peso de jóvenes: {acumuladorJoven / 5.0}");
        Console.WriteLine($"Promedio de peso de adultos: {acumuladorAdulto / 5.0}");
        Console.WriteLine($"Promedio de peso de viejos: {acumuladorViejo / 5.0}");
    }
}
