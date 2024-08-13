using System;

namespace LibraryManagementSystem.Model
{
    public class Book
    {
        // ISBN of the book
        public string ISBN { get; set; }

        // Title of the book
        public string Title { get; set; }

        // Author of the book
        public string Author { get; set; }

        // Published date of the book
        public DateTime PublishedDate { get; set; }
    }
}
