using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1
{
    internal class ConsoleUtils
    {
        //public static void ClearConsole()
        //{
        //    Clear();
        //    WriteLine("\x1b[3J");
        //}

        public static void PrintDialogue(string name, string dialogue, ConsoleColor color = ConsoleColor.Blue)
        {
            int nameLength = name.Length;
            int dialogueLength = dialogue.Length;

            const int padding = 4; // Adjust as needed for spaces

            int borderWidth = 3; // Width of left and right borders
            int maxWidth = Math.Max(nameLength + dialogueLength + padding + borderWidth, 20); // Minimum width of 20

            string formattedDialogue = $"{name} : {dialogue}";

            int paddingWidth = Math.Max(maxWidth - formattedDialogue.Length - borderWidth * 2, 0); // Calculate padding width

            ForegroundColor = ConsoleColor.Gray;
            WriteLine($"+{new string('-', maxWidth - 2)}+");
            WriteLine($"| {new string(' ', formattedDialogue.Length + paddingWidth)} |"); // comment out to make chat box shorter
            Write("| ");

            // Speaker's name appears in custom color
            ForegroundColor = color;
            Write(name);

            ForegroundColor = ConsoleColor.Gray;
            WriteLine($" : {dialogue}{new string(' ', paddingWidth)} |");
            WriteLine($"| {new string(' ', formattedDialogue.Length + paddingWidth)} |"); // comment out to make chat box shorter
            WriteLine($"+{new string('-', maxWidth - 2)}+");
            ResetColor();
            WriteLine();

            WaitForKey();
        }

        public static void Quit()
        {
            WaitForKey("Thanks for playing! Press any key to exit...");

            Environment.Exit(0);
        }

        public static void WaitForKey(string waitingText = "Press any key...")
        {
            WriteLine($"\n{waitingText}");
            ReadKey(true);
        }
    }
}
