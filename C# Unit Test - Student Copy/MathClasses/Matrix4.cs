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
        public float m2 { get => matrix[0]; set => matrix[0] = value; }
        public float m3 { get => matrix[0]; set => matrix[0] = value; }
        public float m4 { get => matrix[0]; set => matrix[0] = value; }
        public float m5 { get => matrix[0]; set => matrix[0] = value; }
        public float m6 { get => matrix[0]; set => matrix[0] = value; }
        public float m7 { get => matrix[0]; set => matrix[0] = value; }
        public float m8 { get => matrix[0]; set => matrix[0] = value; }
        public float m9 { get => matrix[0]; set => matrix[0] = value; }
        public float m10 { get => matrix[0]; set => matrix[0] = value; }
        public float m11 { get => matrix[0]; set => matrix[0] = value; }
        public float m12 { get => matrix[0]; set => matrix[0] = value; }
        public float m13 { get => matrix[0]; set => matrix[0] = value; }
        public float m14 { get => matrix[0]; set => matrix[0] = value; }
        public float m15 { get => matrix[0]; set => matrix[0] = value; }
        public float m16 { get => matrix[0]; set => matrix[0] = value; }

        public Matrix4()
        {
            m1 = 1; m2 = 0; m3 = 0; m4 = 0;
            m5 = 0; m6 = 1; m7 = 0; m8 = 0;
            m9 = 0; m10= 0; m11= 1; m12= 0;
            m13= 0; m14= 0; m15= 0; m16= 1;
        }

    }
}
