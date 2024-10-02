// Програма для створення нового масиву Y на основі масиву X

using System;
using System.Collections.Generic;

class ArrayFilter // Клас для фільтрації масиву
{
    private int[] array; // Масив, який будемо фільтрувати
    private int threshold; // Порогове значення

    public ArrayFilter(int[] array, int threshold) // Конструктор для ініціалізації масиву та порогу
    {
        this.array = array;
        this.threshold = threshold;
    }

    public int[] FilterArray() // Метод для фільтрації масиву за модулем
    {
        List<int> filtered = new List<int>(); // Створюємо список для збереження результату
        foreach (var num in array) // Проходимо по кожному елементу масиву
        {
            if (Math.Abs(num) > threshold) // Перевіряємо, чи більше число за модулем порогу
            {
                filtered.Add(num); // Додаємо число до нового масиву
            }
        }
        return filtered.ToArray(); // Повертаємо відфільтрований масив
    }

    public void PrintArray(int[] arr) // Метод для виведення масиву
    {
        foreach (var num in arr) // Цикл для кожного елемента масиву
        {
            Console.Write(num + " "); 
        }
        Console.WriteLine();
    }
}

class Program 
{
    static void Main() 
    {
        int num = 7; // Остання цифра номеру студента
        int length = 10 + num; // Довжина масиву
        int[] X = new int[length]; // Ініціалізація масиву

        Console.WriteLine($"Введіть масив з {length} елементів:"); 
        for (int i = 0; i < length; i++) // Цикл для зчитування масиву
        {
            X[i] = int.Parse(Console.ReadLine()); // Введення елементів
        }

        Console.WriteLine("Введіть число М:"); 
        int M = int.Parse(Console.ReadLine()); 

        ArrayFilter filter = new ArrayFilter(X, M); // Створюємо об'єкт для фільтрації
        int[] Y = filter.FilterArray(); // Отримуємо відфільтрований масив

        Console.WriteLine($"Число М: {M}"); 
        Console.WriteLine("Масив X:"); 
        filter.PrintArray(X); 
        Console.WriteLine("Масив Y (елементи більше за модулем М):"); 
        filter.PrintArray(Y); 
    }
}
