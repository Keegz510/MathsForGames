using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    [Flags]
    public enum Bitmask : UInt32
    {
        RED = 4278190080,
        GREEN = 16711680,
        BLUE = 65280,
        ALPHA = 255
    }

    public class Colour
    {
        public UInt32 colour;

        public Colour()
        {
            colour = 0;
        }

        public Colour(byte red, byte green, byte blue, byte alpha)
        {
            colour = (UInt32)(red << 24) + (UInt32)(green << 16) + (UInt32)(blue << 8) + (UInt32)alpha;
        }

        public byte GetRed() => (byte)((colour & (UInt32)Bitmask.RED) >> 24);
        public uint SetRed(byte red) => (UInt32)((colour & ~(UInt32)Bitmask.RED) | (uint)(red << 24));

    }
}
