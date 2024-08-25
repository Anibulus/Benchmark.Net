using System;

public class Quicksort
{
    // Método público para ordenar un arreglo de enteros
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
        {
            return; // No se necesita ordenar si el arreglo es nulo o tiene 1 o menos elementos
        }
        
        QuicksortRecursive(array, 0, array.Length - 1);
    }

    // Método recursivo que implementa el algoritmo Quicksort
    private static void QuicksortRecursive(int[] array, int low, int high)
    {
        if (low < high)
        {
            // Encuentra el índice de partición
            int partitionIndex = Partition(array, low, high);

            // Ordena los elementos antes y después del índice de partición
            QuicksortRecursive(array, low, partitionIndex - 1);
            QuicksortRecursive(array, partitionIndex + 1, high);
        }
    }

    // Método para encontrar el índice de partición y reordenar los elementos
    private static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high]; // El pivote es el último elemento
        int i = (low - 1); // Índice del elemento más pequeño

        for (int j = low; j < high; j++)
        {
            // Si el elemento actual es menor o igual al pivote
            if (array[j] <= pivot)
            {
                i++;
                // Intercambia array[i] con array[j]
                Swap(array, i, j);
            }
        }

        // Intercambia array[i + 1] con array[high] (o el pivote)
        Swap(array, i + 1, high);

        return i + 1;
    }

    // Método para intercambiar dos elementos en el arreglo
    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
