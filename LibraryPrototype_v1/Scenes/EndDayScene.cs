using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryPrototype_v1.Entities;
using LibraryPrototype_v1.Menus;
using static System.Console;

namespace LibraryPrototype_v1.Scenes
{
    internal class EndDayScene : Scene
    {
        public EndDayScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            Clear();

            BackgroundColor = ConsoleColor.DarkBlue;
            WriteLine("\n End of Day Report \n");
            ResetColor();

            WriteLine($"Days Played.................{this.Game.Library.DaysPlayed}\n");
            WriteLine($"Library Reputation..........{this.Game.Library.Reputation}\n");
            WriteLine($"# of Visitors...............{this.Game.Library.TotalVisitors}\n");
            WriteLine($"Balance.....................{this.Game.Library.Balance.ToString("C")}\n");

            ConsoleUtils.WaitForKey();

            RunEODMenu();
        }

        private void RunEODMenu()
        {
            Menu eodOptionsMenu = new Menu("What would you like to do?", new string[] { "Start New Day", $"Shop ({this.Game.Library.Balance.ToString("C")})", "Quit" });

            int selectedOption = eodOptionsMenu.GetSelectedOption();

            switch (selectedOption)
            {
                case 0:
                    break;
                case 1:
                    this.Game.ShopScene.Run();
                    RunEODMenu();
                    break;
                case 2:
                    ConsoleUtils.Quit();
                    break;
            }
        }
    }
}
