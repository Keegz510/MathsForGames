using System;
using System.Collections;
using System.Collections.Generic;
using static Raylib_cs.Raylib;

namespace TankGame
{
    class TankProject
    {
        public static void Main()
        {
            InitWindow(1600, 800, "AIE Graphical Test");
            Game game = new Game();
            game.Init();

            while(!WindowShouldClose())
            {
                game.Update();
            }

            CloseWindow();
        }
    }
}