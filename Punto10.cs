class Program
{
	static void Main()
	{
		int totalCorrientes = 0;
		int totalRecomendados = 0;
		double totalRecaudadoLocal = 0;
		double totalRecaudadoNacional = 0;
		double totalRecaudadoInternacional = 0;

		while (true)
		{
			Console.WriteLine("�Desea calcular el valor de env�o de una carta? (si/no)");
			string continuar = Console.ReadLine().ToLower();

			if (continuar != "si")
			{
				break;
			}

			Console.WriteLine("Ingrese el peso de la carta en gramos:");
			int peso = int.Parse(Console.ReadLine());

			Console.WriteLine("Ingrese el tipo de env�o (corriente/recomendado):");
			string tipoEnvio = Console.ReadLine().ToLower();

			Console.WriteLine("Ingrese el destino (local/nacional/internacional):");
			string destino = Console.ReadLine().ToLower();

			double valorEnvio = 0;

			if (tipoEnvio == "corriente")
			{
				switch (destino)
				{
					case "local":
						valorEnvio = 100;
						break;
					case "nacional":
						valorEnvio = 150;
						break;
					case "internacional":
						valorEnvio = 200;
						break;
					default:
						Console.WriteLine("Destino no v�lido.");
						continue;
				}
				totalCorrientes++;
			}
			else if (tipoEnvio == "recomendado")
			{
				switch (destino)
				{
					case "local":
						valorEnvio = 200;
						break;
					case "nacional":
						valorEnvio = 300;
						break;
					case "internacional":
						valorEnvio = 400;
						break;
					default:
						Console.WriteLine("Destino no v�lido.");
						continue;
				}
				totalRecomendados++;
			}
			else
			{
				Console.WriteLine("Tipo de env�o no v�lido.");
				continue;
			}

			double iva = valorEnvio * 0.16;
			double valorTotal = valorEnvio + iva;

			Console.WriteLine($"Valor a pagar por el env�o: {valorTotal:C}");
			Console.WriteLine($"IVA (16%): {iva:C}");

			switch (destino)
			{
				case "local":
					totalRecaudadoLocal += valorTotal;
					break;
				case "nacional":
					totalRecaudadoNacional += valorTotal;
					break;
				case "internacional":
					totalRecaudadoInternacional += valorTotal;
					break;
			}
		}

		Console.WriteLine("Resumen:");
		Console.WriteLine($"Total de cartas corrientes: {totalCorrientes}");
		Console.WriteLine($"Total de cartas recomendadas: {totalRecomendados}");
		Console.WriteLine($"Recaudaci�n total en env�os locales: {totalRecaudadoLocal:C}");
		Console.WriteLine($"Recaudaci�n total en env�os nacionales: {totalRecaudadoNacional:C}");
		Console.WriteLine($"Recaudaci�n total en env�os internacionales: {totalRecaudadoInternacional:C}");
	}
}

