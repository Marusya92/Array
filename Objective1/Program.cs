//  Задайте одномерный массив из 10 целых чисел от 1 до 100.
//  Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 11, 24, 37, 48, 55, 62, 73, 86, 99 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int countInRange = CountElementsInRangeWithFor(array, 20, 90);

        Console.WriteLine($"Количество элементов в отрезке [20, 90]: {countInRange}");
    }

    static int CountElementsInRangeWithFor(int[] array, int min, int max)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= min && array[i] <= max)
            {
                count++;
            }
        }

        return count;
    }

    static void PrintArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }

}