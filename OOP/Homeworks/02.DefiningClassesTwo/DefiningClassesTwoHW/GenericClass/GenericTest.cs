using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generics;

namespace GenericsTests
{
    public static class GenericTest
    {
        public static void Main()
        {
            GenericList<int> testList = new GenericList<int>();

            var random = new Random();

            for (int i = 0; i < 15; i++)
            {
                testList.Add(random.Next(100));
            }

            Console.WriteLine("List:    {0}", testList);
            int max = testList.Max();
            int min = testList.Min();
            int maxIndex = testList.Find(max);
            int minIndex = testList.Find(min);
            Console.WriteLine("Max: {0} Index: {1}", max, maxIndex);
            Console.WriteLine("Min: {0} Index: {1}", min, minIndex);


            Console.WriteLine("Remove min");
            testList.RemoveById(minIndex);
            Console.WriteLine("List:    {0}", testList);
            max = testList.Max();
            min = testList.Min();
            maxIndex = testList.Find(max);
            minIndex = testList.Find(min);
            Console.WriteLine("Max: {0} Index: {1}", max, maxIndex);
            Console.WriteLine("Min: {0} Index: {1}", min, minIndex);

            Console.WriteLine("Remove max");
            testList.RemoveById(maxIndex);
            Console.WriteLine("List:    {0}", testList);
            max = testList.Max();
            min = testList.Min();
            maxIndex = testList.Find(max);
            minIndex = testList.Find(min);
            Console.WriteLine("Max: {0} Index: {1}", max, maxIndex);
            Console.WriteLine("Min: {0} Index: {1}", min, minIndex);
        }
    }
}
