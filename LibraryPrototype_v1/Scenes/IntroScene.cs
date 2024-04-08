using LibraryPrototype_v1.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1.Scenes
{
    internal class IntroScene : Scene
    {
        public IntroScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            RunPartOne();
            RunPartTwo();
            RunPartThree();
            RunPartFour();
        }

        private void RunPartOne()
        {
            Clear();
            WriteLine("You have arrived at the old library in the forest after a long and arduous journey.\n");
            ConsoleUtils.WaitForKey();

            ForegroundColor = ConsoleColor.DarkGreen;
            WriteLine(ArtAssets.Building);
            ResetColor();
            ConsoleUtils.WaitForKey();

            WriteLine("You are weary but happy to finally be here.\n");
            ConsoleUtils.WaitForKey();
        }

        private void RunPartTwo()
        {
            Clear();
            WriteLine("An old man walks down the drive to meet you.");
            ConsoleUtils.WaitForKey();

            WriteLine(ArtAssets.Dude3);

            ConsoleUtils.PrintDialogue("Larry", $"Welcome, Preeya! It's so nice to finally meet you in person."); // {this.Game.Player.FirstName}
            ConsoleUtils.PrintDialogue("Larry", "What do you think? Is it how you have imagined it these last few months?");
            ConsoleUtils.PrintDialogue("Larry", "I know it could use some work, but that's why you're here, right?");
            ConsoleUtils.PrintDialogue("Larry", "Golly gee whilakers, where are my manners? Here I am going on and on and you must be exhausted. Come inside, please!");
        }

        private void RunPartThree()
        {
            Clear();
            WriteLine("You hike your bag up on your shoulder and slowly make your way up the hill towards the library entrance.\n");
            ConsoleUtils.WaitForKey();

            WriteLine("As you approach closer you are able to see just how old the library really is.\n");
            ConsoleUtils.WaitForKey();

            ForegroundColor = ConsoleColor.DarkGray;
            WriteLine(ArtAssets.Entrance);
            ResetColor();
            ConsoleUtils.WaitForKey();

            WriteLine("The bricks are faded and crumbling, and the facade is covered with English ivy.\n");
            ConsoleUtils.WaitForKey();

            WriteLine("For a moment, you wonder what you've gotten yourself into.");
            ConsoleUtils.WaitForKey();
        }

        private void RunPartFour()
        {
            Clear();
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine(ArtAssets.Librarian);
            ResetColor();
            WriteLine("Larry walks over to you and solemnly hands you a small manila envelope, hesitating just for a moment.\n");
            ConsoleUtils.WaitForKey();

            WriteLine("You shake its contents out into the palm of your hand and a heavy, ornate key falls out.\n");
            ConsoleUtils.WaitForKey();

            ConsoleUtils.PrintDialogue("Larry", $"The place is yours now, Preeya."); //{this.Game.Player.FirstName}
            ConsoleUtils.PrintDialogue("Larry", "It's going to be hard work to bring this place to its former glory, but we all believe in you!");

            WriteLine("You go to bed early so that you can get a good night's rest before tomorrow's grand opening.");
            ConsoleUtils.WaitForKey();

            this.Game.MainGameLoop();
        }
    }
}
