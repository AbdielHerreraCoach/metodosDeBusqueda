using System;
using System.Collections.Generic;

public class MetodosBusqueda
{
    public static int[] GenerarArreglo(int tamaño)
    {
        Random random = new Random();
        int[] arreglo = new int[tamaño];

        for (int i = 0; i < tamaño; i++)
            arreglo[i] = random.Next(1, 100);

        return arreglo;
    }

    public static int BusquedaSecuencial(int[] arreglo, int valor)
    {
        for (int i = 0; i < arreglo.Length; i++)
            if (arreglo[i] == valor)
                return i;

        return -1;
    }

    public static int BusquedaBinaria(int[] arreglo, int valor)
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

    public static Dictionary<int, bool> CrearTablaHash(int[] arreglo)
    {
        Dictionary<int, bool> tabla = new Dictionary<int, bool>();

        foreach (int num in arreglo)
            if (!tabla.ContainsKey(num))
                tabla.Add(num, true);

        return tabla;
    }

    public static bool BusquedaHash(Dictionary<int, bool> tabla, int valor)
    {
        return tabla.ContainsKey(valor);
    }
}
