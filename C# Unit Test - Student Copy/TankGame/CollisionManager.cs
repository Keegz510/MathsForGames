using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClasses;

namespace TankGame
{
    public struct BoxSize
    {
        public int Width, Height;
    }
    public class CollisionManager
    {

        public List<SceneObject> CollisionObjects = new List<SceneObject>();

        public void CheckCollisions()
        {
            
            foreach(var so in CollisionObjects.ToList())
            {
                if (!so.hasCollision) continue;

                foreach(var so2 in CollisionObjects.ToList())
                {
                    if (!so.hasCollision) continue;
                    if (so.GlobalTransform.m7 > so2.GlobalTransform.m7 && so.GlobalTransform.m7 < so2.GlobalTransform.m7 + so2.ColSize.Width)
                    {
                        if(so.GlobalTransform.m8 > so2.GlobalTransform.m7 && so.GlobalTransform.m8 < so2.GlobalTransform.m8 + so2.ColSize.Height)
                        {
                            if(so.Tag == "Bullet")
                            {
                                Globals.AllObjectsInScene.Remove(so);
                            }
                        }
                    }    
                }
            }
        }

        
    }

    
}
