using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class GsmDisplay
    {
        private double size;
        private long colors;
        public GsmDisplay(double size, long colors)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size must be greater than zero!");
                }

                this.size = value;
            }
        }

        public long Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Colors must be greater than zero!");
                }

                this.colors = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Size: {0}inc\nColors: {1}", this.Size, this.Colors);
        }
    }
}
