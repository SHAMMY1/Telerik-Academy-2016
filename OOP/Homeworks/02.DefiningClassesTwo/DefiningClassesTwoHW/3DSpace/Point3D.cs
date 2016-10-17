using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSpace
{
    public struct Point3D
    {
        private static readonly Point3D pointZero = new Point3D(0, 0, 0);

        public static Point3D Parse(string pointsAsString)
        {
            try
            {
                var pointsArray = pointsAsString.Split(',').Select(double.Parse).ToArray();

                return new Point3D(pointsArray[0], pointsArray[1], pointsArray[2]);
            }
            catch (Exception)
            {
                
                throw new FormatException("Sring not in format for parsing - X,Y,Z");
            }
        }

        public static Point3D PointZero
        {
            get
            {
                return pointZero;
            }
        }

        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        public Point3D(double x, double y, double z) 
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.X, this.Y, this.Z);
        }
    }
}
