using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Items
{
    public class GsmCall
    {
        public DateTime DateAndTime { get; set; }

        public string PhoneNumber { get; set; }

        public int Duration { get; set; }

        public GsmCall(DateTime dateAndTime, string phoneNumber, int duration)
        {
            this.DateAndTime = dateAndTime;
            this.PhoneNumber = phoneNumber;
            this.Duration = duration;
        }

        public static bool operator ==(GsmCall first, GsmCall second)
        {
            return first.DateAndTime == second.DateAndTime && first.PhoneNumber == second.PhoneNumber;
        }

        public static bool operator !=(GsmCall first, GsmCall second)
        {
            return first.DateAndTime != second.DateAndTime || first.PhoneNumber != second.PhoneNumber;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("Date and time: {0}\n", this.DateAndTime);
            result.AppendFormat("Dialled phone number: {0}\n", this.PhoneNumber);
            result.AppendFormat("Duration: {0}\n", this.Duration);

            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            return this == (GsmCall)obj;
        }
    }
}
