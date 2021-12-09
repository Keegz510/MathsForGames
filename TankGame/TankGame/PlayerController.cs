using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace TankGame
{
    public class PlayerController
    {
        TankObject player;

        public PlayerController(TankObject player)
        {
            this.player = player;
        }

        public void Input()
        {
            if (IsKeyDown(KeyboardKey.KEY_W) && !IsKeyDown(KeyboardKey.KEY_S)) player.Forward();

            if (IsKeyDown(KeyboardKey.KEY_S) && !IsKeyDown(KeyboardKey.KEY_W)) player.Backwards();

            if (IsKeyDown(KeyboardKey.KEY_A) && !IsKeyDown(KeyboardKey.KEY_D)) player.TurnLeft();

            if (IsKeyDown(KeyboardKey.KEY_D) && !IsKeyDown(KeyboardKey.KEY_A)) player.TurnRight();

            if (IsKeyDown(KeyboardKey.KEY_Q) && !IsKeyDown(KeyboardKey.KEY_E)) player.TurretLeft();

            if (IsKeyDown(KeyboardKey.KEY_E) && !IsKeyDown(KeyboardKey.KEY_Q)) player.TurretRight();

            if (IsKeyDown(KeyboardKey.KEY_SPACE)) player.Fire();
        }
    }
}
