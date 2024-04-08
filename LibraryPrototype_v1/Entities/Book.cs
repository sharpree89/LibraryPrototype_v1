using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1.Entities
{
    internal class Book : GameObject
    {
        public string Author { get; private set; }
        public string Genre { get; private set; }

        public Book(string name, int size, double price, string author, string genre)
              : base(name, size, price)
        {
            Author = author;
            Genre = genre;
        }
    }
}
