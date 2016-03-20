﻿namespace CohesionAndCoupling
{
    public class Cube
    {
        public static double Width { get; set; }

        public static double Height { get; set; }

        public static double Depth { get; set; }

        public static double CalculateDiagonalXYZ()
        {
            double distance = DistanceCalculator.CalculateDistance3D(0, 0, 0, Width, Height, Depth);
            return distance;
        }

        public static double CalculateDiagonalXY()
        {
            double distance = DistanceCalculator.CalculateDistance2D(0, 0, Width, Height);
            return distance;
        }

        public static double CalculateDiagonalXZ()
        {
            double distance = DistanceCalculator.CalculateDistance2D(0, 0, Width, Depth);
            return distance;
        }

        public static double CalculateDiagonalYZ()
        {
            double distance = DistanceCalculator.CalculateDistance2D(0, 0, Height, Depth);
            return distance;
        }

        public static double CalcVolume()
        {
            double volume = Width * Height * Depth;
            return volume;
        }
    }
}