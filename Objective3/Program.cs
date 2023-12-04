// Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

using System;

class Program
{
    static void Main()
    {
        double[] array = { 12.3, 52.4, 25.5, 78.1, 34.6, 89.7 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        double difference = FindDifferenceWithFor(array);

        Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
    }

    static double FindDifferenceWithFor(double[] array)
    {
        if (array.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым.");
        }

        double min = array[0];
        double max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
            }

            if (array[i] > max)
            {
                max = array[i];
            }
        }

        double difference = max - min;

        return difference;
    }

    static void PrintArray(double[] array)
    {
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }
}