using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<string> Subjects { get; set; }

    public Student(string name, int age, List<string> subjects)
    {
        Name = name;
        Age = age;
        Subjects = subjects;
    }
}

class Program
{
    static void Main()
    {
       
        List<Student> students = new List<Student>
        {
            new Student("Анатолій Анатолійович", 25, new List<string> { "Фіз-ра", "Біологія", "Географія" }),
            new Student("Василь Васильович", 19, new List<string> { "Хімія", "Фізика", "Історія" }),
            new Student("Андрій Андрійович", 99, new List<string> { "Математика", "Математика", "Математика" })
        };

        
        string json = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("students.json", json);
        Console.WriteLine("Список студентів серіалізовано в файл 'students.json'.\n");

        string jsonFromFile = File.ReadAllText("students.json");
        List<Student> deserializedStudents = JsonSerializer.Deserialize<List<Student>>(jsonFromFile);

        Console.WriteLine("Інформація про студентів після десеріалізації:");
        foreach (var student in deserializedStudents)
        {
            Console.WriteLine($"Ім'я: {student.Name}, Вік: {student.Age}, Предмети: {string.Join(", ", student.Subjects)}");
        }

       
        deserializedStudents.Add(new Student("Дмитро Яковенко", 22, new List<string> { "Фізика", "Історія" }));
        Console.WriteLine("\nДодано нового студента: Дмитро Яковенко\n");

        var studentToUpdate = deserializedStudents.Find(s => s.Name == "Анатолій Анатолійович");
        if (studentToUpdate != null)
        {
            studentToUpdate.Age = 25;  
            studentToUpdate.Subjects.Add("Спортивний забіг");  
            Console.WriteLine("\nДані студента Анатолія Анатолійовича оновлено.\n");
        }

        string updatedJson = JsonSerializer.Serialize(deserializedStudents, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("updated_students.json", updatedJson);
        Console.WriteLine("Оновлений список студентів серіалізовано в файл 'updated_students.json'.\n");

        string updatedJsonFromFile = File.ReadAllText("updated_students.json");
        List<Student> updatedStudents = JsonSerializer.Deserialize<List<Student>>(updatedJsonFromFile);

        Console.WriteLine("Оновлена інформація про студентів:");
        foreach (var student in updatedStudents)
        {
            Console.WriteLine($"Ім'я: {student.Name}, Вік: {student.Age}, Предмети: {string.Join(", ", student.Subjects)}");
        }
    }
}
