using Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallHistoryTest
{
    public class CallHistoryTest
    {
        static void Main()
        {
            GSM gsm = new GSM("X6", "NOKIA");

            gsm.AddCall(new GsmCall(new DateTime(2016,6,15,8,11,0), "+359555000555", 60));
            gsm.AddCall(new GsmCall(new DateTime(2016,6,15,7,11,0), "+359555000555", 70));
            gsm.AddCall(new GsmCall(new DateTime(2016,6,15,6,11,0), "+359555000555", 60));
            gsm.AddCall(new GsmCall(new DateTime(2016,6,15,5,11,0), "+359555000555", 50));
            gsm.AddCall(new GsmCall(new DateTime(2016,6,15,4,11,0), "+359555000555", 60));
            gsm.AddCall(new GsmCall(new DateTime(2016,6,15,3,11,0), "+359555000555", 85));

            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine(call);
            }

            Console.WriteLine("Call history count: {0}", gsm.CallHistory.Count);

            Console.WriteLine("Total call price: {0}", gsm.CalculateCallsPrice(0.37m).ToString("F3"));

            var callToRemove = new GsmCall(new DateTime(2016, 6, 15, 3, 11, 0), "+359555000555", 85);

            gsm.DeleteCall(callToRemove);

            Console.WriteLine("Call history count: {0}", gsm.CallHistory.Count);

            Console.WriteLine("Total call price: {0}", gsm.CalculateCallsPrice(0.37m).ToString("F3"));

            gsm.ClearCallHistory();

            Console.WriteLine("Call history count: {0}", gsm.CallHistory.Count);
        }
    }
}
