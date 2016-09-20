using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class GsmBattery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;

        public GsmBattery(string model, double hoursIdle, double hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Model cannot be null, empty or whitespace!");
                }

                this.model = value;
            }
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("hoursIdle must be greater than zero!");
                }

                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("HoursTalk must be greater than zero!");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType Type { get; set; }

        public override string ToString()
        {
            return string.Format("Model: {0}\nHours idle:{1}\nHours talk:{2}\nType: {3}", this.Model, this.HoursIdle, this.HoursTalk, this.Type);
        }
    }
}
