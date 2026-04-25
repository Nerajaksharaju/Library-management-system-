using Spectre.Console;

namespace LibraryManagementSystem;

internal class BooksController
{

    internal void ViewBooks()
    {
        AnsiConsole.MarkupLine("[yellow] List of Books: [/]");
        foreach (var book in MockDatabase.Books)
        {
            AnsiConsole.MarkupLine($" [cyan] {book}[/]");
        }

        AnsiConsole.MarkupLine("Press Any Keys to Continue.");
        Console.ReadKey();
    }
    internal void AddBooks()
    {
        var title = AnsiConsole.Ask<string>("Enter the [cyan]title[/] of the bool to add");
        if (MockDatabase.Books.Contains(title))
            AnsiConsole.MarkupLine("[red]This book already exists [/]");
        else
        {
            MockDatabase.Books.Add(title);
            AnsiConsole.MarkupLine("[green] Book added successfully![/]");
        }

        AnsiConsole.MarkupLine("Press Any Key to Continue.");
        Console.ReadKey();
    }

    internal void DeleteBooks()
    {
        if (MockDatabase.Books.Count == 0)
        {
            AnsiConsole.MarkupLine("[red] No books to delete.[/]");
            Console.ReadKey();
            return;
        }

        var bookToDelete = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
            .Title("Select a [red]book[/] to Delete")
            .AddChoices(MockDatabase.Books));
        if (MockDatabase.Books.Contains(bookToDelete))
        {
            MockDatabase.Books.Remove(bookToDelete);
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