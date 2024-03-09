class Punto3
{
    static void Main()
    {
        int clientesSinPagar = 15;
        double descuento = 0.15;
        int kilosMinimos = 10;
        double precioKilo = 3000;


        double clienteDescuento = descuento * precioKilo  * kilosMinimos;
        double totalPrecio = precioKilo * kilosMinimos - clienteDescuento;

        double Ingresos = clientesSinPagar * totalPrecio;

        Console.WriteLine("Descuento por cliente: " + clienteDescuento.ToString("C"));
        Console.WriteLine("Total por cliente con descuento: " + totalPrecio.ToString("C"));
        Console.WriteLine("Ingresos totales para la tienda: " + Ingresos.ToString("C"));
    }
}
