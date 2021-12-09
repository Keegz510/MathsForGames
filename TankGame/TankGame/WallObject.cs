using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClasses;

namespace TankGame
{
    public class WallObject : SceneObject
    {
        public WallObject(Vector3 position) : base(position, new Vector3(0, 0, 0), 0, Globals.Scene)
        {
            hasCollision = true;
            CollisionManager.Instance.CollisionObjects.Add(this);
            sprite = Raylib_cs.Raylib.LoadTexture("CollisionObject.png");
        }
    }
}
