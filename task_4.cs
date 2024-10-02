// Програма для формування нового масиву Y на основі масиву X:

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

        Console.WriteLine("Введіть число М:");
        int M = int.Parse(Console.ReadLine());

        int[] Y = Array.FindAll(X, element => Math.Abs(element) > M);

        Console.WriteLine($"Число М: {M}");
        Console.WriteLine("Масив X:");
        foreach (var item in X)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\nМасив Y (елементи більше за модулем М):");
        foreach (var item in Y)
        {
            Console.Write(item + " ");
        }
    }
}
