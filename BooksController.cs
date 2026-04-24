using Spectre.Console;

namespace LibraryManagementSystem;

internal static class BooksController
{

    private static List<string> books = new List<string>()
    {
        "The Great Gatsby", "To Kill a Mockingbird", "1984", "Pride and Prejudice", "The Catcher in the Rye", "The Hobbit", "Moby-Dick", "War and Peace", "The Odyssey", "The Lord of the Rings", "Jane Eyre", "Animal Farm", "Brave New World", "The Chronicles of Narnia", "The Diary of a Young Girl", "The Alchemist", "Wuthering Heights", "Fahrenheit 451", "Catch-22", "The Hitchhiker's Guide to the Galaxy"
    };
    internal static void ViewBooks()
    {
        AnsiConsole.MarkupLine("[yellow] List of Books: [/]");
        foreach (var book in books)
        {
            AnsiConsole.MarkupLine($" [cyan] {book}[/]");
        }

        AnsiConsole.MarkupLine("Press Any Keys to Continue.");
        Console.ReadKey();
    }
    internal static void AddBooks()
    {
        var title = AnsiConsole.Ask<string>("Enter the [cyan]title[/] of the bool to add");
        if (books.Contains(title))
            AnsiConsole.MarkupLine("[red]This book already exists [/]");
        else
        {
            books.Add(title);
            AnsiConsole.MarkupLine("[green] Book added successfully![/]");
        }

        AnsiConsole.MarkupLine("Press Any Key to Continue.");
        Console.ReadKey();
    }

    internal static void DeleteBooks()
    {
        if (books.Count == 0)
        {
            AnsiConsole.MarkupLine("[red] No books to delete.[/]");
            Console.ReadKey();
            return;
        }

        var bookToDelete = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Select a [red]book[/] to Delete")
            .AddChoices(books));
        if (books.Contains(bookToDelete))
        {
            books.Remove(bookToDelete);
            AnsiConsole.MarkupLine("[red]Book deleted successfully![/]");
        }
        else
        {
            AnsiConsole.MarkupLine("[red]Book not found.[/]");
        }
        AnsiConsole.MarkupLine("Press Any Key to Continue.");
        Console.ReadKey();
    }
}