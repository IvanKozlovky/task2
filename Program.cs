using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
    public int PublicationYear { get; set; }
    public string Group { get; set; }

    private static int _objectCount;

    public Book(string author, string title, int publicationYear, string group)
    {
        Author = author;
        Title = title;
        PublicationYear = publicationYear;
        Group = group;
        _objectCount++;
    }

    public static int ObjectCount => _objectCount;

    public override string ToString()
    {
        return $"{Author} - {Title} ({PublicationYear}) - {Group}";
    }
}

public class Program
{
    public static void Main()
    {
        List<Book> books = new List<Book>
        {
            new Book("Сенкевіч", "Потоп", 1978, "Х"),
            new Book("Ландау", "Механіка", 1989, "У"),
            new Book("Дойль", "Сумчасті", 1990, "Д"),
            new Book("Кафка", "Процес", 1925, "Х"),
            new Book("Набоков", "Лоліта", 1955, "Х"),
            new Book("Кундера", "Жарт", 1967, "У"),
            new Book("Брентон", "Надя", 1928, "Д"),
            new Book("Керуак", "У дорозі", 1957, "Х"),
            new Book("Лакан", "Твори", 1966, "У"),
            new Book("Бютор", "Модифікація", 1957, "Х")
        };

        // Знайти книги, видані до 1960 року
        var booksBefore1960 = books.Where(b => b.PublicationYear < 1960);
        Console.WriteLine("Книги, видані до 1960 року:");
        foreach (var book in booksBefore1960)
        {
            Console.WriteLine(book);
        }

        int maxObjects = 15;
        int minObjects = 5;
        int currentObjects = Book.ObjectCount;
        Console.WriteLine($"Кількість створених об'єктів: {currentObjects}");

        if (currentObjects > maxObjects)
        {
            Console.WriteLine("Кількість об'єктів перевищує граничне значення 1.");
        }
        else if (currentObjects < minObjects)
        {
            Console.WriteLine("Кількість об'єктів менше граничного значення 2.");
        }
        else
        {
            Console.WriteLine("Кількість об'єктів між граничними значеннями 1 та 2.");
        }
    }
}

