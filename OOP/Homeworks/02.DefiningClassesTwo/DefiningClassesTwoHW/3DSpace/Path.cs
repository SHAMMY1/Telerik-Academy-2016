using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3DSpace
{
    public class Path
    {
        private Point3D[] points;

        public Point3D[] Points 
        {
            get
            {
                return this.points;
            }
            private set
            {
                this.points = value;
            }
        }

        public Path(params Point3D[] points)
        {
            if (points == null ||points.Length < 2)
            {
                throw new ArgumentException("points cannnot be null or less than 2!");
            }

            this.Points = points.ToArray();
        }

        public override string ToString()
        {
            return string.Join(" ", this.Points);
        }
    }
}
