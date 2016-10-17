using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Safe
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            var allFlights = new List<Flight>();
            while (!(input[0] == -1 && input[1] == -1))
            {
                var currentFlight = new Flight(input[0], input[1]);

                if (allFlights.Contains(currentFlight))
                {
                    allFlights.Remove(currentFlight);
                }
                else
                {
                    allFlights.Add(currentFlight);
                }
                input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }
            Console.WriteLine(allFlights.Count);
        }
    }

    class Flight
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Flight(int start, int end)
        {
            this.Start = start;
            this.End = end;
        }

        public static bool operator ==(Flight first, Flight second)
        {
            if (first.Start == second.Start && first.End == second.End)
            {
                return true;
            }
            if (first.Start == second.End && first.End == second.Start)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Flight first, Flight second)
        {
            return !(first == second);
        }

        public override bool Equals(object obj)
        {
            return this == (Flight)obj;
        }
    }
}
