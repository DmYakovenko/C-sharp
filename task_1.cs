// Програма для вибору чисел, що належать інтервалу [1, 10+№]

using System;

class NumberFilter // Клас для фільтрації чисел за заданим інтервалом
{
    private int lowerBound; // Нижня межа інтервалу
    private int upperBound; // Верхня межа інтервалу

    public NumberFilter(int number) // Конструктор, що задає межі інтервалу
    {
        lowerBound = 1; // Завжди 1 як нижня межа
        upperBound = 10 + number; // Верхня межа залежить від числа №
    }

    public void FilterNumbers(int[] numbers) // Метод для фільтрації чисел з масиву
    {
        Console.WriteLine($"Числа в інтервалі [{lowerBound}, {upperBound}]:"); 
        foreach (var number in numbers) // Цикл для перевірки кожного числа :)))
        {
            if (number >= lowerBound && number <= upperBound) // Перевіряємо, чи число належить інтервалу
            {
                Console.WriteLine(number); // Виводимо число, яке належить інтервалу
            }
        }
    }
}

class Program 
{
    static void Main() 
    {
        int num = 7; // Остання цифра номеру студента
        NumberFilter filter = new NumberFilter(num); // Створюємо об'єкт для фільтрації

        Console.WriteLine("Введіть три числа:"); 
        int[] numbers = new int[3]; // Масив для трьох чисел
        for (int i = 0; i < 3; i++) // Цикл для введення чисел
        {
            numbers[i] = int.Parse(Console.ReadLine()); // Зчитуємо кожне число
        }

        filter.FilterNumbers(numbers); // Викликаємо метод для фільтрації чисел
    }
}
