using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSpace
{
    public class _3DSpaceTest
    {
        public static void Main()
        {
            var firstPoint = new Point3D(1, 1, 1);
            var secondPoint = new Point3D(2, 2, 2);
            double distance = DistanceCalculater.Calculate(firstPoint, secondPoint);

            Console.WriteLine("zero point: {3}\nfirst point: {0}\nsecond point: {1}\ndistance: {2:F3}", firstPoint, secondPoint, distance, Point3D.PointZero);

            var path = new Path(Point3D.PointZero, firstPoint, secondPoint);
            Console.WriteLine("path: {0}", path);

            PathStorage.SavePath("ThePath", path);
            Console.WriteLine("path saved");

            var newPath = PathStorage.LoadPath("ThePath");
            Console.WriteLine("new path loaded");

            Console.WriteLine("New pth: {0}", newPath);
        }
    }
}
