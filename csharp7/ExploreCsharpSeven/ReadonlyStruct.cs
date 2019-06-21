using System;

namespace ExploreCsharpSeven
{

    static class ReadonlyStruct
    {
        #region ReadOnlyPoint
        public struct Point3D
        {
            private static Point3D origin = new Point3D(0, 0, 0);

            public static ref readonly Point3D Origin => ref origin;

            public double X { get; }
            public double Y { get; }
            public double Z { get; }

            private double? distance;

            public Point3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
                distance = null;
            }

            public double ComputeDistance()
            {
                if (!distance.HasValue)
                    distance = Math.Sqrt(X * X + Y * Y + Z * Z);
                return distance.Value;
            }

            public static Point3D Translate(in Point3D source, double dX, double dY, double dZ) =>
                new Point3D(source.X + dX, source.Y + dY, source.Z + dZ);

            public override string ToString()
                => $"({X}, {Y}, {Z})";
        }
        #endregion

        public static int ModifyTheOrigin()
        {
            #region TestReadOnlyPoint
            ref readonly var start = ref Point3D.Origin;
            Console.WriteLine($"Start at the origin: {start}");

            // Move the start:
            var location = Point3D.Translate(in start, 5, 5, 5);
            Console.WriteLine($"Translate by (5,5,5): {location}");

            Console.WriteLine($"Distance to origin is {location.ComputeDistance()}");

            Console.WriteLine($"Check the origin again: {Point3D.Origin}");
            #endregion
            return 0;
        }

    }
}
