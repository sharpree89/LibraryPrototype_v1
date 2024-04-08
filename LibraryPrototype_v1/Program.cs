using System.Runtime.CompilerServices;
using static System.Console;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryPrototype_v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Title = "Library Manager Sim";
            WindowWidth = 240;
            WindowHeight = 60;

            //string text = "Hello World";

            //Console.WriteLine($"{text,-20}"); // Left-aligned padding
            //Console.WriteLine($"{text,20}");  // Right-aligned padding

            Game game = new Game();
            game.Run();

            // testing git connection
        }
    }
}