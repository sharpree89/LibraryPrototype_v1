using LibraryPrototype_v1.Data_Fixtures;
using LibraryPrototype_v1.Entities;
using LibraryPrototype_v1.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1.Scenes
{
    internal class CreateCharacterScene : Scene
    {
        public CreateCharacterScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            Clear();

            string name = ValidateNameInput();

            Clear();
            WriteLine($"Hello, {name}!");
            ConsoleUtils.WaitForKey();

            string gender = RunGenderMenu();

            ConsoleColor color = RunColorMenu();

            // Show Player info
            Clear();
            ForegroundColor = color;
            WriteLine($"Name: {name}");
            WriteLine($"Gender: {gender}");
            ResetColor();
            BackgroundColor = color;
            WriteLine("  Your Color  ");
            ResetColor();

            ConsoleUtils.WaitForKey();

            // Ask for confirmation before starting the game intro
            RunPlayerConfirmMenu(name, gender, color);
        }

        private string ValidateNameInput()
        {
            string name;

            do
            {
                Write("What is your name? ");
                name = ReadLine().Trim(); // Trim any leading or trailing whitespace

                if (string.IsNullOrEmpty(name))
                {
                    WriteLine("Please enter a valid name.");
                }
                else if (name.Length > 16)
                {
                    WriteLine("Name must be 16 characters or less.");
                    name = ""; // Reset name to trigger loop iteration
                }
            } while (string.IsNullOrEmpty(name));

            return name;
        }

        private string RunGenderMenu()
        {
            Menu genderMenu = new Menu("What is your gender?", new string[] { "Female", "Male", "NB" });

            int selectedOption = genderMenu.GetSelectedOption();

            string gender = "Female";

            switch (selectedOption)
            {
                case 0:
                    gender = "Female";
                    break;
                case 1:
                    gender = "Male";
                    break;
                case 2:
                    gender = "NB";
                    break;
            }

            return gender;
        }

        private ConsoleColor RunColorMenu()
        {
            Menu colorMenu = new Menu(
                "Choose a color:",
                new string[] {
                    "Red",
                    "Green",
                    "Cyan",
                    "Blue",
                    "Purple",
                    "Magenta"
            });

            int selectedOption = colorMenu.GetSelectedOption();

            ConsoleColor color = ConsoleColor.Green;

            switch (selectedOption)
            {
                case 0:
                    color = ConsoleColor.DarkRed;
                    break;
                case 1:
                    color = ConsoleColor.DarkGreen;
                    break;
                case 2:
                    color = ConsoleColor.DarkCyan;
                    break;
                case 3:
                    color = ConsoleColor.Blue;
                    break;
                case 4:
                    color = ConsoleColor.DarkMagenta;
                    break;
                case 5:
                    color = ConsoleColor.Magenta;
                    break;
            }

            return color;
        }

        private void RunPlayerConfirmMenu(string name, string gender, ConsoleColor color)
        {
            Menu confirmMenu = new Menu(
                "Are you happy with your selections? You won't be able to make changes later.",
                new string[] { "Yes, show me my character!", "No, I need to start over", }
            );

            int selectedOption = confirmMenu.GetSelectedOption();

            switch (selectedOption)
            {
                case 0:
                    Clear();
                    this.Game.Player = new Player(name, "", 34, gender, color);
                    this.Game.Player.DisplayInfo();

                    //InitLibrary();

                    this.Game.Library = new Library($"{this.Game.Player.FirstName}'s Library", 108, 5000.00);
                    this.Game.Patrons = PatronFixtures.Patrons;
                    this.Game.LibraryBooks = BookFixtures.ClassicBooks;

                    ConsoleUtils.WaitForKey();
                    this.Game.IntroScene.Run();
                    break;
                case 1:
                    this.Game.CreateCharacterScene.Run();
                    break;  
            }
        }

    //    private void InitLibrary()
    //    {
    //        // Create Starter Library
    //        Library library = new Library($"{this.Game.Player.FirstName}'s Library", 108, 5000.00);

    //        Room room1 = new Room("Main Room", 8, 800.00);

    //        Shelf classicShelf = new Shelf("Classics", 16, 100.00);
    //        //Shelf fantasyShelf = new Shelf("Fantasy", 16, 100.00);

    //        // Add Room to Libary's rooms
    //        library.Rooms = new List<Room> { room1 };

    //        // Add Shelf to Room's shelves
    //        room1.Shelves = new List<Shelf> { classicShelf };

    //        // Add Books to Shelves' books
    //        classicShelf.Books = BookFixtures.ClassicBooks;
    //        //fantasyShelf.Books = BookFixtures.FantasyBooks;

    //        // ----------

    //        ForegroundColor = ConsoleColor.Blue;
    //        WriteLine("===== Library Info =====\n");
    //        WriteLine("Library Name: {0}\n", library.Name);
    //        WriteLine($"Rooms in Library: {library.Rooms.Count}\n");

    //        WriteLine("Room Type: {0}\n", room1.Name);
    //        WriteLine($"Shelves in Room: {room1.Shelves.Count}/{room1.Size}");

    //        foreach (Shelf s in room1.Shelves)
    //        {
    //            WriteLine("\n----------\n");
    //            WriteLine($"Shelf Type: {s.Name}");
    //            WriteLine($"Books on Shelf: {s.Books.Count}/{s.Size}\n");

    //            foreach (Book b in s.Books)
    //            {
    //                WriteLine($"Title: {b.Name}");
    //                WriteLine($"Author: {b.Author}");
    //                WriteLine($"Pages: {b.Size}");
    //                WriteLine($"Genre: {b.Genre}");
    //                WriteLine($"Price: {b.Price.ToString("C")}");
    //                WriteLine("\n----------\n");
    //            }
    //        }

    //        ResetColor();

    //        WriteLine("\n----------\n");
    //    }
    }
}
