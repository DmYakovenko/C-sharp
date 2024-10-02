// Програма для обчислення периметра, площі та визначення виду трикутника:

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть три сторони трикутника:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (IsValidTriangle(a, b, c))
        {
            double perimeter = a + b + c;
            double semiPerimeter = perimeter / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));

            Console.WriteLine($"Периметр трикутника: {perimeter}");
            Console.WriteLine($"Площа трикутника: {area}");
            Console.WriteLine($"Вид трикутника: {GetTriangleType(a, b, c)}");
        }
        else
        {
            Console.WriteLine("Це не дійсний трикутник.");
        }
    }

    static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }

    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
            return "Рівносторонній";
        else if (a == b || b == c || a == c)
            return "Рівнобедрений";
        else
            return "Різносторонній";
    }
}
