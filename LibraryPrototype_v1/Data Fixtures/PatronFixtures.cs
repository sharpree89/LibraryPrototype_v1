using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryPrototype_v1.Entities;

namespace LibraryPrototype_v1.Data_Fixtures
{
    internal class PatronFixtures
    {
        public static List<Patron> Patrons = new List<Patron>
        {
            new Patron("Preeya", "Sharma", 34, "Female", ConsoleColor.Magenta, new List<string> { "Pixel art", "Nutrition", "Video games" }),
            new Patron("Balthazar", "Wifflebottom", 45, "Male", ConsoleColor.Blue, new List<string> { "Skydiving", "Juggling", "Extreme knitting" }),
            new Patron("Twinkle", "Toadstool", 28, "Female", ConsoleColor.Magenta, new List<string> { "Stargazing", "Baking", "Astrology" }),
            //new Patron("Dweezil", "Fizzlesprocket", 52, "Male", ConsoleColor.DarkGreen, new List<string> { "Inventing", "LARPing", "Dungeon mastering" }),
            //new Patron("Prudence", "Whimsyfeather", 37, "Female", ConsoleColor.DarkRed, new List<string> { "Fairy gardening", "Antiquing", "Tea leaf reading" }),
            //new Patron("Bubbles", "McGiggles", 19, "Female", ConsoleColor.DarkBlue, new List<string> { "Bubble blowing", "Stand-up comedy", "Belly dancing" }),
            //new Patron("Ziggy", "Fluffernutter", 31, "Non-binary", ConsoleColor.DarkGreen, new List<string> { "Mixology", "DJing", "Gardening" }),
            //new Patron("Snickerdoodle", "Muffintop", 63, "Male", ConsoleColor.DarkRed, new List<string> { "Birdwatching", "Sudoku", "Model train building" }),
            //new Patron("Flutterby", "Rainbowsparkle", 27, "Female", ConsoleColor.DarkMagenta, new List<string> { "Yoga", "Crystal healing", "Renaissance festivals" }),
            //new Patron("Whizbang", "Fizzletop", 40, "Male", ConsoleColor.Blue, new List<string> { "Dungeons & Dragons", "Hiking", "Experimental cooking" }),
            //new Patron("Giggles", "Snugglebottom", 22, "Female", ConsoleColor.DarkGreen, new List<string> { "Painting", "Archery", "Ghost hunting" })
        };
    }
}
