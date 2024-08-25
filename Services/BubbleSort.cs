using System;

public class BubbleSort
{
    // Método público para ordenar un arreglo de enteros usando Bubble Sort
    public static void Sort(int[] array)
    {
        if (array == null || array.Length <= 1)
        {
            return; // No se necesita ordenar si el arreglo es nulo o tiene 1 o menos elementos
        }
        
        int n = array.Length;
        bool swapped;
        
        // Itera sobre el arreglo
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            
            // Compara elementos adyacentes y los intercambia si están en el orden incorrecto
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    Swap(array, j, j + 1);
                    swapped = true;
                }
            }
            
            // Si no hubo intercambios en esta pasada, el arreglo ya está ordenado
            if (!swapped)
            {
                break;
            }
        }
    }

    // Método para intercambiar dos elementos en el arreglo
    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}
