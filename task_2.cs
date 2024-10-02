// Програма для обчислення периметра, площі та визначення виду трикутника

using System;

class Triangle // Клас для роботи з трикутниками
{
    private double a, b, c; // Сторони трикутника

    public Triangle(double a, double b, double c) // Конструктор для ініціалізації сторін
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public bool IsValid() // Перевіряємо, чи є трикутник дійсним
    {
        return a + b > c && a + c > b && b + c > a; // Правило існування трикутника
    }

    public double Perimeter() // Обчислюємо периметр
    {
        return a + b + c; // Сума сторін
    }

    public double Area() // Обчислюємо площу
    {
        double s = Perimeter() / 2; // Півпериметр
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); // Формула Герона для площі
    }

    public string GetTriangleType() // Визначаємо тип трикутника
    {
        if (a == b && b == c)
            return "Рівносторонній"; 
        else if (a == b || b == c || a == c)
            return "Рівнобедрений"; 
        else
            return "Різносторонній"; 
    }
}

class Program 
{
    static void Main() 
    {
        Console.WriteLine("Введіть три сторони трикутника:"); 
        double a = double.Parse(Console.ReadLine()); // parse - переобразуєм в int
        double b = double.Parse(Console.ReadLine()); 
        double c = double.Parse(Console.ReadLine()); 

        Triangle triangle = new Triangle(a, b, c); // Створюємо об'єкт трикутника

        if (triangle.IsValid()) 
        {
            Console.WriteLine($"Периметр трикутника: {triangle.Perimeter()}"); 
            Console.WriteLine($"Площа трикутника: {triangle.Area()}"); 
            Console.WriteLine($"Вид трикутника: {triangle.GetTriangleType()}"); 
        }
        else
        {
            Console.WriteLine("Це не дійсний трикутник."); 
        }
    }
}
