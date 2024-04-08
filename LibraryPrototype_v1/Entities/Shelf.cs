using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1.Entities
{
    internal class Shelf : GameObject
    {
        // todo: shelves should be able to hold other things (magazines, newspapers, relics)
        public List<Book> Books;

        public Shelf(string name, int size, double price)
              : base(name, size, price)
        {
            Books = new List<Book>();


        }
    }
}
