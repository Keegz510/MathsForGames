using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClasses;

namespace TankGame
{
    public static class Globals
    {
        public static float DeltaTime;

        public static SceneObject Scene = new SceneObject();            /// ROOT SCENE OBJECT
        public static List<SceneObject> AllObjectsInScene = new List<SceneObject>();

        //Returns the 2D rotation matrix of a given angle
        public static Matrix3 RotationMatrix2D(float v)
        {
            return new Matrix3(
                (float)Math.Cos(-v), (float)-Math.Sin(-v), 0,
                (float)Math.Sin(-v), (float)Math.Cos(-v), 0,
                 0, 0, 1);
        }

        public static System.Numerics.Vector2 Vec3toVec2(Vector3 vec) => new System.Numerics.Vector2(vec.x, vec.y);

        public static Vector3 DistanceDirectionToXY(float distance, float direction)
        {
            return new Vector3(distance * (float)-Math.Sin(direction), distance * (float)Math.Cos(direction), 0);
        }

        internal static Vector3 PointOffsetDistDir(float distance, float direction)
        {
            return new Vector3(distance * (float)Math.Sin(direction), distance * (float)Math.Cos(direction), 1);
        }
    }
}
