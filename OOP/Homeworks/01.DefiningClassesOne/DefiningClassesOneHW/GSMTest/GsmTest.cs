using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items;

namespace GSMTest
{
    class GsmTest
    {
        static void Main()
        {
            GSM[] GSMs = new GSM[]
            {
                new GSM("Galaxy6", "Samsung", 600, null, new GsmBattery("AAA", 20.5, 4.5), new GsmDisplay(5, 100000000000)),
                new GSM("Lumia", "Nokia", 500, null, new GsmBattery("AA", 25.5, 5.5), new GsmDisplay(5, 1600000000000))
            };

            foreach (var gsm in GSMs)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
