﻿namespace CSharp9.Tests.Helpers
{
    public readonly struct Point
    {
        public Point(int x, int y) => (X, Y) = (x, y);

        public int X { get; }
        public int Y { get; }

        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);

        public static Point Transform(Point point) => point switch
        {
            { X: 0, Y: 0 } => new Point(0, 0),
            { X: var x, Y: var y } when x < y => new Point(x + y, y),
            { X: var x, Y: var y } when x > y => new Point(x - y, y),
            { X: var x, Y: var y } => new Point(2 * x, 2 * y),
        };
    }

    // Record types implicitly provide a Deconstruct method.
    public record Point2D(int X, int Y);
    public record Point3D(int X, int Y, int Z);

}
