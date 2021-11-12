using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x, y, z, w;                // The vector values

        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        // Float constructor
        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        // Addition of 2 Vector4s
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4
            (
                lhs.x + rhs.x,
                lhs.y + rhs.y,
                lhs.z + rhs.z,
                lhs.w + rhs.w
            );
        }

        // Addition of 2 Vector4s
        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4
            (
                lhs.x - rhs.x,
                lhs.y - rhs.y,
                lhs.z - rhs.z,
                lhs.w - rhs.w
            );
        }

    }
}
