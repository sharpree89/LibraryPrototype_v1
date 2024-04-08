using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LibraryPrototype_v1.Assets;
using LibraryPrototype_v1.Entities;
using LibraryPrototype_v1.Menus;
using LibraryPrototype_v1.Scenes;
using static System.Console;

namespace LibraryPrototype_v1
{
    internal class Game
    {
        public Stopwatch Stopwatch;
        public bool IsGameRunning;
        public Player? Player;
        public Library? Library;
        public List<Patron>? Patrons;
        public List<Book> LibraryBooks;
        public List<Book> ShopBooks;

        public TitleScene TitleScene;
        public CreateCharacterScene CreateCharacterScene;
        public IntroScene IntroScene;
        public CreditsScene CreditsScene;
        public StartDayScene StartDayScene;
        public EndDayScene EndDayScene;
        public ShopScene ShopScene;

        public Game()
        {
            //this.Stopwatch = Stopwatch.StartNew();

            this.IsGameRunning = false;
            this.LibraryBooks = BookFixtures.ClassicBooks;
            this.ShopBooks = BookFixtures.FantasyBooks;

            this.TitleScene = new TitleScene(this);
            this.CreateCharacterScene = new CreateCharacterScene(this);
            this.IntroScene = new IntroScene(this);
            this.CreditsScene = new CreditsScene(this);
            this.StartDayScene = new StartDayScene(this);
            this.EndDayScene = new EndDayScene(this);
            this.ShopScene = new ShopScene(this);
        }

        public void Run()
        {
            if (!this.IsGameRunning)
            {
                this.IsGameRunning = true;

                this.TitleScene.Run();
            }
        }

        public void MainGameLoop()
        {
            while (true)
            {
                Clear();

                this.StartDayScene.Run();

                foreach (Patron patron in this.Patrons)
                {
                    this.Library.TotalVisitors += 1;

                    patron.DisplayInfo();
                    ConsoleUtils.WaitForKey();

                    RunPatronQueueMenu(patron);
                }

                // End of Day Calculations
                this.Library.DaysPlayed += 1;
                this.Library.Reputation += 5;
                this.Library.Balance += 50.00;

                this.EndDayScene.Run();
            }
        }

        private void RunPatronQueueMenu(Patron patron)
        {
            Menu patronMenu = new Menu("What will you do?", new string[] { "Greet", "Spy", "Ignore" });

            int selectedOption = patronMenu.GetSelectedOption();

            switch (selectedOption)
            {
                case 0:
                    this.Library.Reputation += 1;
                    this.Library.Balance += 5;

                    WriteLine($"\nYou greet {patron.FirstName} with a big smile and ask if they need help finding a book.\n");
                    ConsoleUtils.WaitForKey();
                    Clear();
                    break;
                case 1:
                    // Occupation, Favorite Book, Overdue Books
                    WriteLine($"\n{patron.FirstName}'s Interests:\n");

                    foreach (string interest in patron.Interests)
                    {
                        WriteLine(interest);
                    }

                    ConsoleUtils.WaitForKey();
                    Clear();

                    break;
                case 2:
                    this.Library.Reputation -= 2;

                    WriteLine($"\nYou avoid {patron.FirstName}'s gaze, hoping they don't notice you or ask you any questions.\n");
                    ConsoleUtils.WaitForKey();
                    Clear();
                    break;
            }
        }

    }
}

