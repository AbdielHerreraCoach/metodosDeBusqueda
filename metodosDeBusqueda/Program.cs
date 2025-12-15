using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] arreglo = MetodosBusqueda.GenerarArreglo(10);

        Console.WriteLine("Arreglo generado:");
        Console.WriteLine(string.Join(", ", arreglo));

        Console.Write("\nIngrese el número a buscar: ");
        int valor = int.Parse(Console.ReadLine());

        Console.WriteLine("\nSeleccione el método de búsqueda:");
        Console.WriteLine("1. Búsqueda Secuencial");
        Console.WriteLine("2. Búsqueda Binaria");
        Console.WriteLine("3. Búsqueda Hash");
        Console.Write("Opción: ");
        int opcion = int.Parse(Console.ReadLine());

        int resultado;

        switch (opcion)
        {
            case 1:
                resultado = MetodosBusqueda.BusquedaSecuencial(arreglo, valor);
                MostrarResultado(resultado);
                break;

            case 2:
                Array.Sort(arreglo);
                Console.WriteLine("\nArreglo ordenado:");
                Console.WriteLine(string.Join(", ", arreglo));
                resultado = MetodosBusqueda.BusquedaBinaria(arreglo, valor);
                MostrarResultado(resultado);
                break;

            case 3:
                Dictionary<int, bool> tabla = MetodosBusqueda.CrearTablaHash(arreglo);
                bool encontrado = MetodosBusqueda.BusquedaHash(tabla, valor);
                Console.WriteLine(encontrado
                    ? "Elemento encontrado en la tabla hash"
                    : "Elemento no encontrado");
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }

    static void MostrarResultado(int resultado)
    {
        if (resultado != -1)
            Console.WriteLine("Elemento encontrado en la posición: " + resultado);
        else
            Console.WriteLine("Elemento no encontrado");
    }
}
