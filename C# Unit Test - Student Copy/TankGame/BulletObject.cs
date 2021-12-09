using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClasses;

namespace TankGame
{
    public class BulletObject : SceneObject
    {
        private static float movementSpeed = 100.0f;


        public BulletObject(Vector3 position, float rotation) : base(position, Globals.DistanceDirectionToXY(movementSpeed, rotation), rotation + (float)Math.PI, Globals.Scene)
        {
            sprite = Raylib_cs.Raylib.LoadTexture("bullet.png");                //Sets the sprite
            friction = 0;                                                       //No friction
            offset = new Vector3(-sprite.width / 2, -sprite.height / 2, 0);   //Sets the offset for the bullet (Centered)
            Scale = 1.0f;                                                         //Full scale
            tag = "Bullet";
        }
    }
}
