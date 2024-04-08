using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1.Menus
{
    internal class Menu
    {
        private string Prompt;
        private string[] Options;
        private int SelectedOption;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedOption = 0;
        }

        private void DisplayOptions()
        {
            // Display Menu Prompt
            WriteLine(Prompt);

            for (int i = 0; i < Prompt.Length; i++)
            {
                Write("-");
            }

            // Display Menu Options
            WriteLine("\n");

            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];

                if (i == SelectedOption)
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }

                string formattedOption = FormatOptionString(currentOption);

                WriteLine(formattedOption);
            }

            ResetColor();
        }

        private string FormatOptionString(string currentOption)
        {
            // Find the maximum length among all options
            int maxLength = Options.Max(option => option.Length);

            // Add 4 more padding to each side
            maxLength += 12;

            // Calculate padding for each side
            int paddingInt = (maxLength - currentOption.Length) / 2;

            // If the length is odd, add an extra space to the end
            // so that the final printed option is perfectly centered
            string extraSpace = "";

            if ((maxLength - currentOption.Length) % 2 != 0)
            {
                extraSpace = " ";
            }

            // Create a string of empty spaces where the string's length
            // is equal to the amount of padding calculated above
            string paddingStr = new string(' ', paddingInt);

            // Return the final formatted string
            return $"{paddingStr}{currentOption}{paddingStr}{extraSpace}";
        }

        public int GetSelectedOption()
        {
            ConsoleKey keyPressed;

            // Note about do-while vs while:

            // The benefit of using a do-while in this case is ensuring that
            // the menu is displayed at least once before checking for player input.

            // Player could press enter before the menu has a chance to display, and it
            // would never get displayed because the break condition was already met.
            do
            {
                // Everytime player presses a key, re-render the menu

                // TODO: there is a way to not clear the whole screen!
                Clear();
                DisplayOptions();

                // Capture the player's pressed key
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                // update SelectedOption based on arrow keys
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    // decrement SelectedOption (move toward top of list)
                    SelectedOption--;

                    // Cycle to last option instead of going off screen
                    if (SelectedOption < 0)
                    {
                        SelectedOption = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    // increment SelectedOption (move toward bottom of list)
                    SelectedOption++;

                    // Cycle to first option instead of going off screen
                    if (SelectedOption == Options.Length)
                    {
                        SelectedOption = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);

            return SelectedOption;
        }
    }
}
