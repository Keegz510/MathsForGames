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
        public float m2 { get => matrix[0]; set => matrix[0] = value; }
        public float m3 { get => matrix[0]; set => matrix[0] = value; }
        public float m4 { get => matrix[0]; set => matrix[0] = value; }
        public float m5 { get => matrix[0]; set => matrix[0] = value; }
        public float m6 { get => matrix[0]; set => matrix[0] = value; }
        public float m7 { get => matrix[0]; set => matrix[0] = value; }
        public float m8 { get => matrix[0]; set => matrix[0] = value; }
        public float m9 { get => matrix[0]; set => matrix[0] = value; }


        public Matrix3()
        {
            m1 = 1; m2 = 0; m3 = 0;
            m4 = 0; m5 = 1; m6 = 0;
            m7 = 0; m8 = 0; m9 = 1;
        }

        public Matrix3(float m1, float m2, float m3, float m4, float m5, float m6, float m7, float m9)
        {
            this.m1 = m1; this.m2 = m2; this.m3 = m3;
            this.m4 = m4; this.m5 = m5; this.m6 = m6;
            this.m7 = m7; this.m8 = m8; this.m9 = m9;
        }

        public Matrix3(float[] m)
        {
            matrix = m;
        }

        

    }
}