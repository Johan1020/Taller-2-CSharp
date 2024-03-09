using System;

class Punto3
{
    static void Main()
    {
        // Definir constantes y variables
        const int cantidadClientes = 15;
        const double porcentajeDescuento = 0.15;
        const double kilosMinimosParaDescuento = 10;

        Console.Write("Ingrese el precio por kilo de naranjas: ");
        double precioPorKilo = double.Parse(Console.ReadLine());

        double descuentoPorCliente = 0;

        double totalIngresosTienda = 0;

        for (int i = 1; i <= cantidadClientes; i++)
        {
            // Solicitar la cantidad de kilos comprados por cada cliente
            Console.Write($"Ingrese la cantidad de kilos comprados por el cliente {i}: ");
            double cantidadKilos = double.Parse(Console.ReadLine());

            if (cantidadKilos > kilosMinimosParaDescuento)
            {
                descuentoPorCliente = porcentajeDescuento * precioPorKilo * cantidadKilos;
            }

            double totalPorCliente = precioPorKilo * cantidadKilos - descuentoPorCliente;

            Console.WriteLine($"El cliente {i} pagará: {totalPorCliente.ToString("C")}");

            totalIngresosTienda += totalPorCliente;
        }
        Console.WriteLine($"La tienda percibirá en total: {totalIngresosTienda.ToString("C")}");
    }
}
