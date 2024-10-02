// Програма для пошуку мінімального і максимального значення у масиві

using System;

class ArrayProcessor // Клас для роботи з масивом
{
    private int[] array; // Масив, з яким працюємо

    public ArrayProcessor(int[] array) // Конструктор для ініціалізації масиву
    {
        this.array = array;
    }

    public int FindMin() // Метод для пошуку мінімального значення
    {
        int minValue = array[0]; // Початкове мінімальне значення
        foreach (var num in array) // Цикл для кожного елемента масиву
        {
            if (num < minValue) // Якщо поточне число менше за мінімальне
                minValue = num; // Оновлюємо мінімальне значення
        }
        return minValue; // Повертаємо мінімум
    }

    public int FindMax() // Метод для пошуку максимального значення
    {
        int maxValue = array[0]; // Початкове максимальне значення
        foreach (var num in array) // Цикл для кожного елемента масиву
        {
            if (num > maxValue) // Якщо поточне число більше за максимальне
                maxValue = num; // Оновлюємо максимальне значення
        }
        return maxValue; // Повертаємо максимум
    }

    public void PrintArray() // Метод для виведення масиву
    {
        Console.WriteLine("Масив:"); // Виведення заголовку
        foreach (var num in array) // Цикл для кожного елемента масиву
        {
            Console.Write(num + " "); // Виведення числа
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        int num = 7; // Остання цифра номеру студента
        int length = 10 + num; // Довжина масиву з урахуванням №
        int[] X = new int[length]; // Ініціалізація масиву

        Console.WriteLine($"Введіть масив з {length} елементів:"); // Запитуємо елементи масиву у користувача
        for (int i = 0; i < length; i++) // Цикл для введення масиву
        {
            X[i] = int.Parse(Console.ReadLine()); // Зчитування числа
        }

        ArrayProcessor processor = new ArrayProcessor(X); // Створюємо об'єкт для обробки масиву
        processor.PrintArray(); // Виводимо масив
        Console.WriteLine($"Мінімальне значення: {processor.FindMin()}"); 
        Console.WriteLine($"Максимальне значення: {processor.FindMax()}"); 
    }
}
