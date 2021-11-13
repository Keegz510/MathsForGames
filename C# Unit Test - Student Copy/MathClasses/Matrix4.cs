using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Matrix4
    {
        public float[] matrix = new float[16];

        public float m1 { get => matrix[0]; set => matrix[0] = value; }
        public float m2 { get => matrix[1]; set => matrix[1] = value; }
        public float m3 { get => matrix[2]; set => matrix[2] = value; }
        public float m4 { get => matrix[3]; set => matrix[3] = value; }
        public float m5 { get => matrix[4]; set => matrix[4] = value; }
        public float m6 { get => matrix[5]; set => matrix[5] = value; }
        public float m7 { get => matrix[6]; set => matrix[6] = value; }
        public float m8 { get => matrix[7]; set => matrix[7] = value; }
        public float m9 { get => matrix[8]; set => matrix[8] = value; }
        public float m10 { get => matrix[9]; set => matrix[9] = value; }
        public float m11 { get => matrix[10]; set => matrix[10] = value; }
        public float m12 { get => matrix[0]; set => matrix[11] = value; }
        public float m13 { get => matrix[0]; set => matrix[12] = value; }
        public float m14 { get => matrix[0]; set => matrix[13] = value; }
        public float m15 { get => matrix[0]; set => matrix[14] = value; }
        public float m16 { get => matrix[0]; set => matrix[15] = value; }

        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10= 0; m11= 1; m12= 0;
            m13= 0; m14= 0; m15= 0; m16= 1;
        }

        public Matrix4(float mm1, float mm2, float mm3, float mm4, float mm5, float mm6, float mm7, float mm8, float mm9, float mm10, float mm11, float mm12,
            float mm13, float mm14, float mm15, float mm16)
        {
            m1 = mm1; m2 = mm2; m3 = mm3; m4 = mm4;
            m5 = mm5; m6 = mm6; m7 = mm7; m8 = mm8;
            m9 = mm9; m10 = mm10; m11 = mm11; m12 = mm12;
            m13 = mm13; m14 = mm14; m15 = mm15; m16 = mm16;
        }

        public Matrix4(float[] m)
        {
            matrix = m;
        }

        public Matrix4(Matrix4 m)
        {
            matrix = m.matrix;
        }

        public static Matrix4 operator *(Matrix4 lhs, Matrix4 rhs)
        {
            Matrix4 newMatrix = new Matrix4();
            int matrixDim = 4;                  // Dimension of the matrix

            for(int i = 0; i < matrixDim; i++)
            {
                for(int j = 0; j < matrixDim; j++)
                {
                    for(int k = 0; k < matrixDim; k++)
                    {
                        newMatrix.matrix[i * matrixDim + j] += lhs.matrix[j * matrixDim * k] * rhs.matrix[i * matrixDim + k];
                    }
                }
            }

            return newMatrix;
        }

        public static Vector4 operator *(Matrix4 mat, Vector4 vec)
        {
            return new Vector4
            (
                (mat.m1 * vec.x) + (mat.m5 * vec.y) + (mat.m9 * vec.z) + (mat.m13 * vec.w),
                (mat.m2 * vec.x) + (mat.m6 * vec.y) + (mat.m10 * vec.z) + (mat.m14 * vec.w),
                (mat.m3 * vec.x) + (mat.m7 * vec.y) + (mat.m11 * vec.z) + (mat.m15 * vec.w),
                (mat.m4 * vec.x) + (mat.m8 * vec.y) + (mat.m12 * vec.z) + (mat.m16 * vec.w)
            );


        }

        public void SetRotateX(float radians)
        {
            Matrix4 rotation = new Matrix4
            (
                1, 0, 0, 0,
                0, (float)Math.Cos(-radians), (float)-Math.Sin(-radians), 0,
                0, (float)Math.Sin(-radians), (float)Math.Cos(-radians), 0,
                0, 0, 0, 1
            );

            Matrix4 newMatrix = this * rotation;
            matrix = newMatrix.matrix;
        }

        public void SetRotateY(float radians)
        {
            Matrix4 rotation = new Matrix4
            (
                (float)Math.Cos(-radians), 0, (float)Math.Sin(-radians), 0,
                0, 1, 0, 0,
                (float)-Math.Sin(-radians), 0, (float)Math.Cos(-radians), 0,
                0, 0, 0, 1
            );

            Matrix4 newMatrix = this * rotation;
            matrix = newMatrix.matrix;
        }

        public void SetRotateZ(float radians)
        {
            Matrix4 rotation = new Matrix4
            (
                (float)Math.Cos(-radians), (float)-Math.Sin(-radians), 0, 0,
                (float)Math.Sin(-radians), (float)Math.Cos(-radians), 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1
            );
        }

        public Matrix4 Transpose()
        {
            Matrix4 transposed = new Matrix4();

            for(int i = 0; i < 16; i++)
            {
                transposed.matrix[i] = matrix[(i % 4) * 4 + (int)(i / 4)];
            }

            return transposed;
        }

    }
}
