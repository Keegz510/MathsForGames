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

        // subtraction of 2 Vector4s
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

        // Multiplication of 2 Vector4s
        public static Vector4 operator *(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4
            (
                lhs.x * rhs.x,
                lhs.y * rhs.y,
                lhs.z * rhs.z,
                lhs.w * rhs.w
            );
        }

        // Multiplication of a vector by a float
        public static Vector4 operator *(Vector4 vec, float scale)
        {
            return new Vector4
            (
                vec.x * scale,
                vec.y * scale,
                vec.z * scale,
                vec.w * scale
            );
        }

        // Multiplication of a vector by a float
        public static Vector4 operator *(float scale, Vector4 vec)
        {
            return new Vector4
            (
                vec.x * scale,
                vec.y * scale,
                vec.z * scale,
                vec.w * scale
            );
        }

        // Returns the dot product
        public float Dot(Vector4 vec)
        {
            return (x * vec.x) + (y * vec.y) + (z * vec.z) + (w * vec.w);
        }

        // Returns the magnitude of the vector
        public float Magnitude()
        {
            return (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
        }

        public void Normalize()
        {
            float mag = Magnitude();
            x /= mag;
            y /= mag;
            z /= mag;
        }

        public Vector4 GetNomralized()
        {
            return new Vector4
            (
                x / Magnitude(),
                y / Magnitude(),
                z / Magnitude(),
                0
            );
        }

        public Vector4 Cross(Vector4 vec)
        {
            Vector4 newVector = new Vector4
            {
                x = (y * vec.z) - (z * vec.y),
                y = (z * vec.x) - (x * vec.z),
                z = (x * vec.y) - (y * vec.x),
                w = 0
            };

            return newVector;
        }

    }
}
