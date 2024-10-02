// Програма для пошуку мінімального і максимального значення у масиві:

using System;

class Program
{
    static void Main()
    {
        int num = 7; // Остання цифра в номері студента
        int length = 10 + num;
        int[] X = new int[length];

        Console.WriteLine($"Введіть масив з {length} елементів:");
        for (int i = 0; i < length; i++)
        {
            X[i] = int.Parse(Console.ReadLine());
        }

        int minValue = X[0];
        int maxValue = X[0];

        for (int i = 1; i < X.Length; i++)
        {
            if (X[i] < minValue) minValue = X[i];
            if (X[i] > maxValue) maxValue = X[i];
        }

        Console.WriteLine("Масив:");
        foreach (var item in X)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine($"\nМінімальне значення: {minValue}");
        Console.WriteLine($"Максимальне значення: {maxValue}");
    }
}
