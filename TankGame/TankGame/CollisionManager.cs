using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClasses;

namespace TankGame
{
    public struct BoxBounds
    {
        public int Width, Height;
    }
    public class CollisionManager
    {
        public static CollisionManager Instance;

        public List<SceneObject> CollisionObjects = new List<SceneObject>();

        BoxBounds windowBounds;

        public CollisionManager()
        {
            Instance = this;
        }

        public void CheckBoundsCollision(SceneObject go)
        {
            if(go.hasCollision)
            {
                if (go.GlobalTransform.m7 < 0 || go.GlobalTransform.m7 > windowBounds.Width)
                    go.Destroy();

                if(go.GlobalTransform.m8 < 0 || go.GlobalTransform.m8 > windowBounds.Height)
                    go.Destroy();
            }
            
        }

        public void CreateWindowBounds(int width, int height)
        {
            windowBounds = new BoxBounds
            {
                Width = width,
                Height = height
            };
        }


    }


}
