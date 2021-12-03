using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace TankGame
{
    public class Game
    {
        Image dirt = LoadImage("Images/dirt.png");
        Texture2D background;

        public Game()
        {
            background = LoadTextureFromImage(dirt);
        }

        public void Init()
        {
            
        }

        public void Update()
        {
            Draw();
        }

        public void Draw()
        {
            BeginDrawing();
            ClearBackground(Color.LIGHTGRAY);
            DrawTextureEx(background, Vector2.Zero, 0, 5, Color.WHITE);
            EndDrawing();
        }
    }
}
