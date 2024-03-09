using System;

class Punto8
{
    static void Main()
    {
         int cantidadAlumnos = 10;
         int calificacionAprobatoria = 70;

        int reprobados = 0;

        for (int i = 1; i <= cantidadAlumnos; i++)
        {
            Console.Write($"Ingrese la calificación del alumno {i}: ");

            if (double.TryParse(Console.ReadLine(), out double calificacion))
            {
                if (calificacion < calificacionAprobatoria)
                {
                    reprobados++;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingrese un número entero.");
                i--; 
            }
        }

        double porcentajeReprobados = (double)reprobados / cantidadAlumnos * 100;

        Console.WriteLine($"El porcentaje de alumnos reprobados es: {porcentajeReprobados}%");
    }
}
