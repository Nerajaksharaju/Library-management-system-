using Spectre.Console;
using static LibraryManagementSystem.Enums;

namespace LibraryManagementSystem;

internal class UserInterface
{
    private BooksController booksController = new BooksController();

    internal void MainMenu()
    {
        while (true)
        {
            var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<MenuOption>()
                    .Title("What do you want to do next?")
                    .AddChoices(Enum.GetValues<MenuOption>()));

            switch (choice)
            {
                case MenuOption.Viewbooks:
                    booksController.ViewBooks();
                    break;
                case MenuOption.AddBook:
                    booksController.AddBooks();
                    break;
                case MenuOption.DeleteBook:
                    booksController.DeleteBooks();
                    break;
            }
        }
    }

}
