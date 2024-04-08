using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1.Scenes
{
    internal class Scene
    {
        protected Game Game;

        public Scene(Game game)
        {
            Game = game;
        }

        virtual public void Run()
        {
        }
    }
}
