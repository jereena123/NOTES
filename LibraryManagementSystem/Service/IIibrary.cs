using LibraryManagementSystem.Model;
using System;

namespace LibraryManagementSystem.Service
{
    public interface IIibrary
    {
        // List all books in the library
        void ListAllBooks();

        // Add a new book to the library
        void AddBook(Book book);

        // Edit the details of a book identified by its ISBN
        void EditBook(string isbn);

        // Remove a book from the library by its ISBN
        void RemoveBook(string isbn);

        // Search for books by an author
        void SearchByAuthor(string author);

        // Search for books by their title
        void SearchByTitle(string title);

        // Check if a book with the given ISBN is in the library
        bool Contains(string isbn);

        // Check if a book with the given ISBN exists in the library
        bool BookExists(string isbn);
    }
}
