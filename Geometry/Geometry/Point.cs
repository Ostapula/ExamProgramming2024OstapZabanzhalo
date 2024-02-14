using System;

using System;

namespace Geometry
{
    public class Point : IReflectable
    {
        private decimal _x;
        private decimal _y;

        public decimal X { get { return _x; } }
        public decimal Y { get { return _y; } }

        public Point(decimal x)
        {
            _x = x;
            _y = 0;
        }

        public Point(decimal x, decimal y)
        {
            _x = x;
            _y = y;
        }

        public void ReflectX()
        {
            _x *= (-1);
        }

        public void ReflectY()
        {
            _y *= (-1);
        }

        public override string ToString() => $"({X},{Y})";
    }
}
