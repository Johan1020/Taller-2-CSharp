using System;

class Punto5
{
    static void Main()
    {
        int elefantes = 20;
        int jirafas = 15;
        int chimpances = 40;

        Console.WriteLine("Ingrese la opción de animal a estudiar (elefantes, jirafas o chimpancés):");
        string animal = Console.ReadLine().ToLower();

        int totalMuestras = 0;

        if (animal == "elefantes")
        {
            totalMuestras = elefantes;
        }
        else if (animal == "jirafas")
        {
            totalMuestras = jirafas;
        }
        else if (animal == "chimpancés")
        {
            totalMuestras = chimpances;
        }
        else
        {
            Console.WriteLine("Animal no válido.");
            return;
        }

        int menos1año = 0;
        int mas1yMenos3 = 0;
        int mas3oMas = 0;

        for (int i = 0; i < totalMuestras; i++)
        {
            Console.WriteLine($"Ingrese la edad del {animal.Substring(0, animal.Length - 1)} {i + 1}:");
            int edad;
            while (!int.TryParse(Console.ReadLine(), out edad) || edad < 0)
            {
                Console.WriteLine("Edad no válida. Ingrese una edad válida:");
            }

            if (edad <= 1)
            {
                menos1año++;
            }
            else if (edad > 1 && edad < 3)
            {
                mas1yMenos3++;
            }
            else
            {
                mas3oMas++;
            }
        }

        double porcentajeMenos1año = (double)menos1año / totalMuestras * 100;
        double porcentajeMas1yMenos3 = (double)mas1yMenos3 / totalMuestras * 100;
        double porcentajeMas3oMas = (double)mas3oMas / totalMuestras * 100;

        Console.WriteLine($"Porcentaje de animales de 0 a 1 año: {porcentajeMenos1año}%");
        Console.WriteLine($"Porcentaje de animales de más de 1 año y menos de 3: {porcentajeMas1yMenos3}%");
        Console.WriteLine($"Porcentaje de animales de 3 o más años: {porcentajeMas3oMas}%");
    }
}
