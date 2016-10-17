using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _3DSpace
{
    public static class PathStorage
    {
        private const string DirectoryToSaveAndLoadFrom = "./paths/";

        public static void SavePath(string pathName, Path path)
        {
            if(!Directory.Exists(DirectoryToSaveAndLoadFrom))
            {
                Directory.CreateDirectory(DirectoryToSaveAndLoadFrom);
            }

            using (StreamWriter writer = new StreamWriter(DirectoryToSaveAndLoadFrom + pathName + ".path"))
            {
                writer.WriteLine(path);
            }
        }

        public static Path LoadPath(string pathName)
        {
            IEnumerable<Point3D> points;

            using (StreamReader reader = new StreamReader(DirectoryToSaveAndLoadFrom + pathName + ".path"))
            {
                points = reader.ReadLine().Split(' ').Select(Point3D.Parse);      
            }

            return new Path(points.ToArray());
        }
    }
}
