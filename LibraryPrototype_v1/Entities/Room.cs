using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1.Entities
{
    internal class Room : GameObject
    {
        public List<Shelf> Shelves;

        public Room(string name, int size, double price)
             : base(name, size, price)
        {
            Shelves = new List<Shelf>();
        }
    }
}
