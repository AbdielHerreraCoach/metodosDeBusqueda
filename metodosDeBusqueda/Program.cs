using System;
using System.Collections.Generic;

class MetodosBusqueda
{
    // Búsqueda Secuencial
    static int BusquedaSecuencial(int[] arreglo, int valor)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            if (arreglo[i] == valor)
                return i;
        }
        return -1;
    }

    // Búsqueda Binaria (arreglo ordenado)
    static int BusquedaBinaria(int[] arreglo, int valor)
    {
        int inicio = 0;
        int fin = arreglo.Length - 1;

        while (inicio <= fin)
        {
            int medio = (inicio + fin) / 2;

            if (arreglo[medio] == valor)
                return medio;
            else if (arreglo[medio] < valor)
                inicio = medio + 1;
            else
                fin = medio - 1;
        }
        return -1;
    }

    // Búsqueda Hash
    static bool BusquedaHash(Dictionary<int, bool> tabla, int valor)
    {
        return tabla.ContainsKey(valor);
    }

    static void Main()
    {
        Random random = new Random();
        int[] arreglo = new int[10];

        for (int i = 0; i < arreglo.Length; i++)
            arreglo[i] = random.Next(1, 100);

        Dictionary<int, bool> tablaHash = new Dictionary<int, bool>();
        foreach (int num in arreglo)
            if (!tablaHash.ContainsKey(num))
                tablaHash.Add(num, true);

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
                resultado = BusquedaSecuencial(arreglo, valor);
                if (resultado != -1)
                    Console.WriteLine("Elemento encontrado en la posición " + resultado);
                else
                    Console.WriteLine("Elemento no encontrado");
                break;

            case 2:
                Array.Sort(arreglo);
                Console.WriteLine("Arreglo ordenado:");
                Console.WriteLine(string.Join(", ", arreglo));
                resultado = BusquedaBinaria(arreglo, valor);
                if (resultado != -1)
                    Console.WriteLine("Elemento encontrado en la posición " + resultado);
                else
                    Console.WriteLine("Elemento no encontrado");
                break;

            case 3:
                if (BusquedaHash(tablaHash, valor))
                    Console.WriteLine("Elemento encontrado en la tabla hash");
                else
                    Console.WriteLine("Elemento no encontrado");
                break;

            default:
                Console.WriteLine("Opción inválida");
                break;
        }
    }
}
