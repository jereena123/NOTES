using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem.Service
{
    public class LibraryImpl : IIibrary
    {
        // Dictionary to store books using ISBN as the key
        private static Dictionary<string, Book> books = new Dictionary<string, Book>();

        #region List All Books
        public void ListAllBooks()
        {
            try
            {
                // Check if there are no books in the dictionary
                if (books.Count == 0)
                {
                    Console.WriteLine("No books found.");
                    return;
                }

                // Print the header for the list of books
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("| ISBN         | Title               | Author    |");
                Console.WriteLine("--------------------------------------------------");

                // Iterate through each book 
                foreach (var book in books.Values)
                {
                    Console.WriteLine($"| {book.ISBN,-10} | {book.Title,-18} | {book.Author,-10} |");
                }
                Console.WriteLine("--------------------------------------------------");
            }
            catch (Exception ex)
            {
                // Handle  exceptions 
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        #endregion

        #region Add Book
        public void AddBook(Book book)
        {
            try
            {
                // Check if a book with the same ISBN already exists
                if (books.ContainsKey(book.ISBN))
                {
                    Console.WriteLine($"Book with ISBN {book.ISBN} already exists.");
                }

                // Add the new book to the dictionary
                books.Add(book.ISBN, book);
                Console.WriteLine("New book added successfully.");
            }
            catch (Exception ex)
            {
                // Handle any exceptions 
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        #endregion

        #region Edit Book
        public void EditBook(string isbn)
        {
            try
            {
                // Check if the book with the given ISBN exists
                if (books.ContainsKey(isbn))
                {
                    // Get the book to edit
                    Book book = books[isbn];

                    // Enter a new title 
                    Console.WriteLine("Enter new title:");
                    string newTitle = Console.ReadLine();
                    //Validation(if null or whitespace should not add)
                    if (!string.IsNullOrWhiteSpace(newTitle))
                    {
                        book.Title = newTitle;
                    }

                    //Enter new author
                    Console.WriteLine("Enter new author:");
                    string newAuthor = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(newAuthor))
                    {
                        book.Author = newAuthor;
                    }

                    Console.WriteLine("Book details updated successfully.");
                }
                else
                {
                    Console.WriteLine($"Book with ISBN {isbn} not found.");
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions 
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        #endregion

        #region Remove Book
        public void RemoveBook(string isbn)
        {
            try
            {
                // Check if the book with the given ISBN exists
                if (books.ContainsKey(isbn))
                {
                    // Remove the book from the dictionary
                    books.Remove(isbn);
                    Console.WriteLine("Book removed successfully.");
                }
                else
                {
                   Console.WriteLine($"Book with ISBN {isbn} not found.");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions 
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        #endregion

        #region Search By Author
        public void SearchByAuthor(string author)
        {
            try
            {
                bool found = false;
                // Iterate through each book and check if the author matches
                foreach (var book in books.Values)
                {
                    if (book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{book.Title} by {book.Author} (ISBN: {book.ISBN})");
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No books found by that author.");
                }
            }
            catch (Exception ex)
            {
                // Handle  exceptions 
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        #endregion

        #region Search By Title
        public void SearchByTitle(string title)
        {
            try
            {
                bool found = false;
                // Iterate through each book and check if the title contains the search string
                foreach (var book in books.Values)
                {
                    if (book.Title.IndexOf(title, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine($"{book.Title} by {book.Author} (ISBN: {book.ISBN})");
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No books found with that title.");
                }
            }
            catch (Exception ex)
            {
                // Handle  exceptions 
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        #endregion

        // Check if a book with the given ISBN exists in the dictionary
        public bool BookExists(string isbn)
        {
            return books.ContainsKey(isbn);
        }

        // Check if the dictionary contains a book with the given ISBN
        public bool Contains(string isbn)
        {
            return books.ContainsKey(isbn);
        }
    }
}
