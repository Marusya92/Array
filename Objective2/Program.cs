// Задайте массив на 10 целых чисел.
// Напишите программу, которая определяет количество чётных чисел в массиве.

using System;

class Program
{
    static void Main()
    {
        int[] array = { 3, 7, 15, 28, 32, 46, 55, 67, 77, 89 };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int countEven = CountEvenNumbers(array);

        Console.WriteLine($"Количество чётных чисел в массиве: {countEven}");
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
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





