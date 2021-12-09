using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using static Raylib_cs.Raylib;
using MathClasses;

namespace TankGame
{
    public class Game
    {
        Image dirt = LoadImage("Images/dirt.png");
        Texture2D background;

        PlayerController pc;

        public Game()
        {
            background = LoadTextureFromImage(dirt);
            pc = new PlayerController(new TankObject(new Vector3(100, 100, 1), new Vector3(), -(float)Math.PI / 2, 0, Globals.Scene));
        }

        public void Init()
        {
            Globals.AllObjectsInScene.Add(Globals.Scene);
        }

        public void Update()
        {
            Globals.DeltaTime = GetFrameTime();
            pc.Input();
            Globals.Scene.Update();
            Globals.Scene.PhysicsUpdate();

            Globals.Scene.LocalTransformUpdate();
            Globals.Scene.GlobalTransformUpdate();


            Draw();
        }

        public void Draw()
        {
            BeginDrawing();
            ClearBackground(Color.LIGHTGRAY);
            DrawTextureEx(background, System.Numerics.Vector2.Zero, 0, 5, Color.WHITE);
            Globals.Scene.Draw();
            EndDrawing();
        }
    }
}
