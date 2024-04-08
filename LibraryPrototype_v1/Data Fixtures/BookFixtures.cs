using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryPrototype_v1.Entities;

namespace LibraryPrototype_v1
{
    internal class BookFixtures
    {
        public static List<Book> ClassicBooks = new List<Book>
        {
            new Book("To Kill a Mockingbird", 336, 10.99, "Harper Lee", "Classic"),
            new Book("1984", 328, 9.99, "George Orwell", "Science Fiction"),
            new Book("The Great Gatsby", 180, 7.99, "F. Scott Fitzgerald", "Classic"),
            new Book("Pride and Prejudice", 279, 8.49, "Jane Austen", "Romance"),
            new Book("The Catcher in the Rye", 277, 8.99, "J.D. Salinger", "Coming-of-age"),
            new Book("To the Lighthouse", 209, 12.79, "Virginia Woolf", "Modernist")
        };

        public static List<Book> FantasyBooks = new List<Book>
        {
            new Book("Harry Potter and the Philosopher's Stone", 223, 12.99, "J.K. Rowling", "Fantasy"),
            new Book("Harry Potter and the Chamber of Secrets", 251, 14.99, "J.K. Rowling", "Fantasy"),
            new Book("Harry Potter and the Prisoner of Azkaban", 317, 15.99, "J.K. Rowling", "Fantasy"),
            new Book("Harry Potter and the Goblet of Fire", 636, 17.99, "J.K. Rowling", "Fantasy"),
            new Book("Harry Potter and the Order of the Phoenix", 766, 19.99, "J.K. Rowling", "Fantasy"),
            new Book("Harry Potter and the Half-Blood Prince", 607, 18.99, "J.K. Rowling", "Fantasy"),
            new Book("Harry Potter and the Deathly Hallows", 607, 20.99, "J.K. Rowling", "Fantasy"),
        };
    }
}
