using System;

class Punto6
{
    static void Main()
    {
        // Definir variables
        int cantidadAutos;
        int amarilla = 0, rosa = 0, roja = 0, verde = 0, azul = 0;

        // Solicitar la cantidad de autos
        Console.Write("Ingrese la cantidad de autos que entran a la Ciudad de México: ");

        while (!int.TryParse(Console.ReadLine(), out cantidadAutos) || cantidadAutos < 1)
        {
            Console.WriteLine("Ingrese una cantidad válida.");
        }

        // Registrar el color de la calcomanía para cada auto
        for (int i = 1; i <= cantidadAutos; i++)
        {
            Console.Write($"Ingrese el último dígito de la placa del automóvil {i}: ");

            if (int.TryParse(Console.ReadLine(), out int ultimoDigito))
            {
                switch (ultimoDigito)
                {
                    case 1:
                    case 2:
                        amarilla++;
                        break;
                    case 3:
                    case 4:
                        rosa++;
                        break;
                    case 5:
                    case 6:
                        roja++;
                        break;
                    case 7:
                    case 8:
                        verde++;
                        break;
                    case 9:
                    case 0:
                        azul++;
                        break;
                    default:
                        Console.WriteLine("Dígito no válido. Ingrese un dígito del 0 al 9.");
                        i--;
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingrese un número entero.");
                i--;
            }
        }

        // Mostrar resultados
        Console.WriteLine($"Cantidad de autos con calcomanía amarilla: {amarilla}");
        Console.WriteLine($"Cantidad de autos con calcomanía rosa: {rosa}");
        Console.WriteLine($"Cantidad de autos con calcomanía roja: {roja}");
        Console.WriteLine($"Cantidad de autos con calcomanía verde: {verde}");
        Console.WriteLine($"Cantidad de autos con calcomanía azul: {azul}");
    }
}
