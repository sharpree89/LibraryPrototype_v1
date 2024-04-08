using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1.Scenes
{
    internal class StartDayScene : Scene
    {
        public StartDayScene(Game game) : base(game)
        {
        }

        public override void Run()
        {
            Clear();

            WriteLine("Starting a new day!\n");

            ConsoleUtils.WaitForKey();

            Clear();
        }
    }
}
