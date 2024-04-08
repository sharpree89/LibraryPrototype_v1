using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryPrototype_v1.Entities;
using LibraryPrototype_v1.Menus;
using static System.Console;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryPrototype_v1.Scenes
{
    internal class ShopScene : Scene
    {
        public ShopScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            Clear();

            RunShopMenu();
        }

        private void RunShopMenu()
        {
            string[] shopItems = this.Game.ShopBooks.Select(book => book.Name).ToArray();

            // Create a Menu object with the prompt and the list of item names
            Menu shopMenu = new Menu("Welcome to the Shop! Select a book to purchase:", shopItems);

            // Run the menu
            int selectedOption = shopMenu.GetSelectedOption();

            // Handle the selected option (e.g., process the purchase)
            HandleSelectedOption(selectedOption, shopItems);
        }

        private void HandleSelectedOption(int selectedOption, string[] shopItems)
        {
            // Check if the selected option is within the valid range
            if (selectedOption >= 0 && selectedOption < shopItems.Length)
            {
                // Perform the action corresponding to the selected option
                string selectedItem = shopItems[selectedOption];

                WriteLine(selectedItem);
                ConsoleUtils.WaitForKey();

                // TODO: Add the book to the "LibraryBooks"
                // TODO: Remove it from the "ShopBooks"
            }
            else
            {
                // Handle invalid selection
                WriteLine("Invalid selection. Please try again.");
            }
        }
    }
}
