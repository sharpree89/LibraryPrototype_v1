using LibraryPrototype_v1.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1.Scenes
{
    internal class CreditsScene : Scene
    {
        public CreditsScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            Clear();
            WriteLine("Designed and developed by @UchiMama.");
            ConsoleUtils.WaitForKey("Press any key to return to the Start Menu...");
            this.Game.TitleScene.RunStartMenu();
        }
    }
}
