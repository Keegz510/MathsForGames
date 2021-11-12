using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector3
    {
        public float x, y, z;           // Vector Values

        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        // Constructor for floats
        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Addition of 2 vectors
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3
            (
                lhs.x + rhs.x,
                lhs.y + rhs.y,
                lhs.z + rhs.z
            );
        }

    }
}
