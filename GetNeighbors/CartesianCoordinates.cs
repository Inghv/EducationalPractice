using System;
using System.Collections;

namespace GetNeighbors
{
    public static class CartesianCoordinates
    {
        /// <summary>
        /// Gets from a set of points only points that are h-neighbors for a point with integer coordinates x and y.
        /// </summary>
        /// <param name="point">Given point with integer coordinates x and y.</param>
        /// <param name="h">Distance around a given point.</param>
        /// <param name="points">A given set of points.</param>
        /// <returns>Only points that are h-neighbors for a point with integer coordinates x and y.</returns>
        /// <exception cref="ArgumentNullException">Throw when array points is null.</exception>
        /// <exception cref="ArgumentException">Throw when h-distance is less or equals zero.</exception>
        public static Point[] GetNeighbors(Point point, int h, params Point[]? points)
        {
            if (points is null)
            {
                throw new ArgumentNullException(nameof(points), "Array points is null.");
            }
            else if (h <= 0)
            {
                throw new ArgumentException("h-distance is less or equals zero", nameof(h));
            }

            ArrayList list = new ArrayList();
            for (int i = 0; i < points.Length; i++)
            {
                if ((Math.Abs(points[i].X - point.X) <= h) && (Math.Abs(points[i].Y - point.Y) <= h))
                {
                    list.Add(points[i]);
                }
            }

            Point[] result = new Point[list.Count];
            list.CopyTo(result);
            return result;
        }
    }
}
