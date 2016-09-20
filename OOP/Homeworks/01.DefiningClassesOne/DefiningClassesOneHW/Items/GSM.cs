using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class GSM
    {
        public static GSM IPhone4S = new GSM("IPhone4s", "Apple", 1000, null, new GsmBattery("AAA", 20.5, 5.5), new GsmDisplay(5, 16000000000));

        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private List<GsmCall> callHistory;

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
                    throw new ArgumentException("Model cannot be empty, null or whitespace!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Manufacturer cannot be empty, null or whitespace!");
                }

                this.manufacturer = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price must be greater than zero!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (IsStringEmptyOrWhitespace(value))
                {
                    throw new ArgumentException("Owner cannot be empty, null or whitespace!");
                }

                this.owner = value;
            }
        }

        public List<GsmCall> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            private set
            {
                this.callHistory = value;
            }
        }





        public GsmBattery Battery { get; set; }

        public GsmDisplay Display { get; set; }

        public GSM(string model, string manufacturer, decimal? price, string owner, GsmBattery battery, GsmDisplay display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.CallHistory = new List<GsmCall>();
        }

        public GSM(string model, string manufacturer, decimal? price, string owner, GsmBattery battery)
            : this(model, manufacturer, price, owner, battery, null)
        { }

        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, null, null)
        { }

        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null, null, null)
        { }

        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        { }



        public void AddCall(GsmCall call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCall(GsmCall call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory = new List<GsmCall>();
        }

        public decimal CalculateCallsPrice(decimal pricePerMinute)
        {
            decimal totalSeconds = 0;

            foreach (var call in CallHistory)
            {
                totalSeconds += call.Duration;
            }

            return totalSeconds / 60 * pricePerMinute;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(string.Format("Model: {0}", this.Model));
            result.AppendLine(string.Format("Manufacturer: {0}", this.Manufacturer));
            result.AppendLine(string.Format("Price: {0}", this.Price));
            result.AppendLine(string.Format("Owner: {0}", this.Owner));
            result.AppendLine(string.Format("Battery:\n{0}", this.Battery));
            result.AppendLine(string.Format("Display:\n{0}", this.Display));

            return result.ToString();
        }

                private bool IsStringEmptyOrWhitespace(string value)
        {
            if ((value != null) && ((value.Length == 0) || value.All(x => x == ' ')))
            {
                return true;
            }

            return false;
        }
    }
}
