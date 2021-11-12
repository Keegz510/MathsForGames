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

        // Subtraction of 2 vectors
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3
            (
                lhs.x - rhs.x,
                lhs.y - rhs.y,
                lhs.z - rhs.z
            );
        }

        // Multiplication of 2 vectors
        public static Vector3 operator *(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3
            (
                lhs.x * rhs.x,
                lhs.y * rhs.y,
                lhs.z * rhs.z
            );
        }

        // Multiplaction of a vector by a scale
        public static Vector3 operator *(Vector3 vec, float scale)
        {
            return new Vector3
            (
                vec.x * scale,
                vec.y * scale,
                vec.z * scale
            );
        }

        // Multiplaction of a vector by a scale
        public static Vector3 operator *(float scale, Vector3 vec)
        {
            return new Vector3
            (   
                vec.x * scale,
                vec.y * scale,
                vec.z * scale
            );
        }

        public static bool operator ==(Vector3 lhs, Vector3 rhs)
        {
            if ((lhs.x == rhs.x) && (lhs.y == rhs.y) && (lhs.z == rhs.z))
                return true;

            return false;
        }

        public static bool operator !=(Vector3 lhs, Vector3 rhs)
        {
            return !(lhs == rhs);
        }

        // Returns the dot product of the vector
        public float Dot(Vector3 vec)
        {
            return (x * vec.x) + (y * vec.y) + (z * vec.z);
        }

        // Returns the magnitude of the vector
        public float Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
        }

        // Returns the vector3 to the magnitude of 1
        public void Normalize()
        {
            x /= Magnitude();
            y /= Magnitude();
            z /= Magnitude();
        }

        
    }
}
