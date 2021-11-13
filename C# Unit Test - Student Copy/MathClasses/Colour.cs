using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    [Flags]
    public enum Bitmask : uint
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

    }
}
