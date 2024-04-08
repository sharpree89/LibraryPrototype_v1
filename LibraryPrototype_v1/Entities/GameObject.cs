using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1
{
    internal class GameObject
    {
        public string Name { get; protected set; }
        public int Size { get; protected set; }
        public double Price { get; protected set; }

        public GameObject(string name, int size, double price)
        {
            this.Name = name;
            this.Size = size;
            this.Price = price;
        }
    }
}
