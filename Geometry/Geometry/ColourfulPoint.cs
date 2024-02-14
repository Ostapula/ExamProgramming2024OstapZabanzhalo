using System;

namespace Geometry
{
    public enum PointColour
    {
        Red, Green, Blue
    }

    internal class ColourfulPoint : Point
    {
        public PointColour Colour { get; }

        public ColourfulPoint(double x, double y, PointColour colour) : base(x, y)
        {
            Colour = colour;
        }
    }
}
