using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{

    public class Matrix3
    {
        public float[] matrix = new float[9];                // Matrix array

        public float m1 { get => matrix[0]; set => matrix[0] = value; }
        public float m2 { get => matrix[1]; set => matrix[1] = value; }
        public float m3 { get => matrix[2]; set => matrix[2] = value; }
        public float m4 { get => matrix[3]; set => matrix[3] = value; }
        public float m5 { get => matrix[4]; set => matrix[4] = value; }
        public float m6 { get => matrix[5]; set => matrix[5] = value; }
        public float m7 { get => matrix[6]; set => matrix[6] = value; }
        public float m8 { get => matrix[7]; set => matrix[7] = value; }
        public float m9 { get => matrix[8]; set => matrix[8] = value; }

        
        public Matrix3()
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }

        public Matrix3(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m8, float m9)
        {
            this.m1 = m1; this.m2 = m2; this.m3 = m3;
            this.m4 = m4; this.m5 = m5; this.m6 = m6;
            this.m7 = m7; this.m8 = m8; this.m9 = m9;
        }

        public Matrix3(float[] m)
        {
            matrix = m;
        }

        public void Set(Matrix3 m)
        {
            this.m1 = m.m1; this.m2 = m.m2; this.m3 = m.m3;
            this.m4 = m.m4; this.m5 = m.m5; this.m6 = m.m6;
            this.m7 = m.m7; this.m8 = m.m8; this.m9 = m.m9;
        }

        // Multiplication of 2 matrices
        public static Matrix3 operator *(Matrix3 lhs, Matrix3 rhs)
        {
            Matrix3 transposed = rhs.Transpose();
            Matrix3 newMatrix = new Matrix3();
            /*
            Matrix3 newMatrix = new Matrix3(
                lhs.m1 * rhs.m1, lhs.m2 * rhs.m4, lhs.m3 * rhs.m7,
                lhs.m1 * rhs.m2, lhs.m2 * rhs.m5, lhs.m3 * rhs.m8,
                lhs.m1 * rhs.m3, lhs.m2 * rhs.m6, lhs.m3 * rhs.m9
                );
            */
            for(int i = 0; i < 9; ++i)
            {
                newMatrix.matrix[i] = lhs.matrix[i] * transposed.matrix[i];
            }
           
            

            return newMatrix;
        }


        public static Vector3 operator *(Matrix3 mat, Vector3 vec)
        {
            return new Vector3
            (
                mat.m1 * vec.x + mat.m4 * vec.y + mat.m7 * vec.z,
                mat.m2 * vec.x + mat.m5 * vec.y + mat.m8 * vec.z,
                mat.m3 * vec.x + mat.m6 * vec.y + mat.m9 * vec.z
            );
        }

        public static Vector3 operator *(Vector3 vec, Matrix3 mat)
        {
            return new Vector3
            (
                mat.m1 * vec.x + mat.m4 * vec.y + mat.m7 * vec.z,
                mat.m2 * vec.x + mat.m5 * vec.y + mat.m8 * vec.z,
                mat.m3 * vec.x + mat.m6 * vec.y + mat.m9 * vec.z
            );
        }

        public void SetRotateX(float radians)
        {
            Matrix3 rotation = new Matrix3(
                1, 0 ,0,
                0, (float)Math.Cos(-radians), (float)-Math.Sin(-radians),
                0, (float)Math.Sin(-radians), (float)Math.Cos(-radians));

            Set(rotation);
        }

        public void SetRotateY(float radians)
        {
            Matrix3 rotation = new Matrix3(
                (float)Math.Cos(-radians), 0, (float)Math.Sin(-radians),
                0, 1, 0,
                (float)-Math.Sin(-radians), 0, (float)Math.Cos(-radians));

            Set(rotation);
        }

        public void SetRotateZ(float radians)
        {
            Matrix3 rotation = new Matrix3(
                (float)Math.Cos(-radians), (float)-Math.Sin(-radians), 0,
                (float)Math.Sin(-radians), (float)Math.Cos(-radians), 0,
                          0,                     0,                 1);

            Set(rotation);
        }

        public Matrix3 Transpose()
        {
            Matrix3 transposed = new Matrix3();

            transposed.matrix[0] = m1; transposed.matrix[1] = m4; transposed.matrix[2] = m7;
            transposed.matrix[3] = m2 ; transposed.matrix[4] = m5; transposed.matrix[5] = m8;
            transposed.matrix[6] = m3; transposed.matrix[7] = m6; transposed.matrix[8] = m9;

            return transposed;

        }

    }
}