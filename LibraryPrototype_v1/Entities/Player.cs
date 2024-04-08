using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPrototype_v1
{
    internal class Player : Character
    {
        public Player(
            string firstName, 
            string? lastName, 
            int age, 
            string gender, 
            ConsoleColor color
        )
        : base(firstName, lastName, age, gender, color)
        {
        }
    }
}
