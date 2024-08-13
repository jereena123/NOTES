using LibraryManagementSystem.Model;
using LibraryManagementSystem.Service;
using System;

namespace LibraryManagementSystem
{
    public class LibraryApp
    {
        // Field 
        private readonly IIibrary _libraryService;

        // Dependency inverse injection
        public LibraryApp(IIibrary libraryService)
        {
            _libraryService = libraryService;
        }

        static void Main(string[] args)
        {
            // Initialize the library application with an instance of LibraryImpl
            var libraryApp = new LibraryApp(new LibraryImpl());

            // Displaying the menu can be done by loop
            while (true)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Books");
                Console.WriteLine("2. List All Books");
                Console.WriteLine("3. Edit Book");
                Console.WriteLine("4. Remove Book");
                Console.WriteLine("5. Search By Author");
                Console.WriteLine("6. Search By Title");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                // Validate user choice
                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 7)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                // User choice
                switch (choice)
                {
                    case 1:
                        // Create a new book object
                        Book newBook = new Book();

                        Console.WriteLine("Enter the book details that you want to add:");

                        // Validate ISBN input
                        while (true)
                        {
                            Console.WriteLine("ISBN (13 digits):");
                            newBook.ISBN = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(newBook.ISBN) && newBook.ISBN.Length == 13)
                            {
                                if (!libraryApp._libraryService.BookExists(newBook.ISBN))
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("A book with this ISBN already exists.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid ISBN. Please enter a 13-digit ISBN.");
                            }
                        }

                        // Validate Title input
                        while (true)
                        {
                            Console.WriteLine("Title:");
                            newBook.Title = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(newBook.Title))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Title cannot be empty.");
                            }
                        }


                        // Validate Author input
                        while (true)
                        {
                            Console.WriteLine("Author:");
                            newBook.Author = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(newBook.Author) && !System.Text.RegularExpressions.Regex.IsMatch(newBook.Author, @"\d"))
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input for Author. Ensure it is not empty and doesn't contain numbers.");
                            }
                        }

                        // Validate Published Date input
                        while (true)
                        {
                            Console.WriteLine("Published Date (YYYY-MM-DD):");
                            string dateInput = Console.ReadLine();
                            if (DateTime.TryParse(dateInput, out DateTime publishedDate))
                            {
                                newBook.PublishedDate = publishedDate; // Correctly assigning to the instance
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid date format. Please use YYYY-MM-DD.");
                            }
                        }

                        // Add the book to the library
                        libraryApp._libraryService.AddBook(newBook);
                        break;

                    case 2:
                        // List all books in the library
                        libraryApp._libraryService.ListAllBooks();
                        break;

                    case 3:
                        // Edit a book's details
                        try
                        {
                            Console.Write("Enter ISBN of the book to edit: ");
                            string isbn = Console.ReadLine();
                            libraryApp._libraryService.EditBook(isbn);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occurred: {ex.Message}");
                        }
                        break;

                    case 4:
                        // Remove a book from the library
                        try
                        {
                            Console.Write("Enter ISBN of the book to remove: ");
                            string isbn = Console.ReadLine();
                            libraryApp._libraryService.RemoveBook(isbn);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occurred: {ex.Message}");
                        }
                        break;

                    case 5:
                        // Search for books by author
                        try
                        {
                            Console.Write("Enter author name: ");
                            string author = Console.ReadLine();
                            libraryApp._libraryService.SearchByAuthor(author);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occurred: {ex.Message}");
                        }
                        break;

                    case 6:
                        // Search for books by title
                        try
                        {
                            Console.Write("Enter book title: ");
                            string title = Console.ReadLine();
                            libraryApp._libraryService.SearchByTitle(title);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"An error occurred: {ex.Message}");
                        }
                        break;

                    case 7:
                        // Exiting the application
                        return;
                }
            }
        }
    }
}
