// using LibraryManagementSystem;

// UserInterface userInterface = new UserInterface();
// userInterface.MainMenu();

// (string, int) book1 = ("Frankenstein", 350);
// Console.WriteLine($"Title: {book1.Item1}, Pages: {book1.Item2}");

// (string Title, int Pages) book2 = ("Frankenstein", 350);
// Console.WriteLine($"Title: {book2.Title}, Pages: {book2.Pages}");

using TCSA.OOP.LibraryManagementSystem;

var book1 = new Book();
var book2 = new Book("Great Gatsby", 300);
var book3 = new Book(280);