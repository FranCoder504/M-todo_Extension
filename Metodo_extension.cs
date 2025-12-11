using System;
using System.Collections.Generic;
using System.Linq;

public class Alumno
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Nota { get; set; }
}

class Program
{
    static void Main()
    {
        List<Alumno> alumnos = new List<Alumno>
        {
            new Alumno { Nombre = "Ana", Edad = 19, Nota = 5.5 },
            new Alumno { Nombre = "Pedro", Edad = 21, Nota = 3.8 },
            new Alumno { Nombre = "Carlos", Edad = 22, Nota = 6.0 },
            new Alumno { Nombre = "Lucía", Edad = 18, Nota = 4.2 },
            new Alumno { Nombre = "Diego", Edad = 23, Nota = 2.9 }
        };

        // 1. Mayores de 20 años – Query Syntax
        var mayores20 = from a in alumnos
                        where a.Edad > 20
                        select a;

        Console.WriteLine("Alumnos mayores de 20 años:");
        foreach (var a in mayores20)
        {
            Console.WriteLine($"{a.Nombre} ({a.Edad} años)");
        }

        // 2. Ordenar por nombre – Method Syntax
        var ordenados = alumnos.OrderBy(a => a.Nombre);

        Console.WriteLine("\nAlumnos ordenados por nombre:");
        foreach (var a in ordenados)
        {
            Console.WriteLine(a.Nombre);
        }

        // 3. Buscar a "Carlos"
        var carlos = alumnos.FirstOrDefault(a => a.Nombre == "Carlos");
        if (carlos != null)
            Console.WriteLine($"\nCarlos encontrado: Nota = {carlos.Nota:F1}");
        else
            Console.WriteLine("\nCarlos no encontrado.");

        // Extra: Filtrar mayores de 20 y ordenar
        var filtradoOrdenado = alumnos
            .Where(a => a.Edad > 20)
            .OrderBy(a => a.Nombre);

        Console.WriteLine("\nMayores de 20, ordenados por nombre (extra):");
        foreach (var a in filtradoOrdenado)
        {
            Console.WriteLine(a.Nombre);
        }
    }
}
