using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryPrototype_v1.Entities;
using static System.Console;

namespace LibraryPrototype_v1
{
    internal class Patron : Character
    {
        public Book? FavoriteBook;
        public List<Book> BorrowedBooks;
        public List<string> Interests;

        public Patron(
            string firstName, 
            string? lastName, 
            int age, 
            string gender, 
            ConsoleColor color,
            List<string> interests
        ) 
        : base(firstName, lastName, age, gender, color)
        {
            this.BorrowedBooks = new List<Book>();
            this.Interests = interests;
        }
    }
}
