// Програма для вибору чисел, що належать інтервалу [1, 10+№]:

using System;

class Program
{
    static void Main()
    {
        int num = 7; // Остання цифра в номері студента
        int lowerBound = 1;
        int upperBound = 10 + num;

        Console.WriteLine("Введіть три числа:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine($"Числа в інтервалі [{lowerBound}, {upperBound}]:");
        if (a >= lowerBound && a <= upperBound) Console.WriteLine(a);
        if (b >= lowerBound && b <= upperBound) Console.WriteLine(b);
        if (c >= lowerBound && c <= upperBound) Console.WriteLine(c);
    }
}
