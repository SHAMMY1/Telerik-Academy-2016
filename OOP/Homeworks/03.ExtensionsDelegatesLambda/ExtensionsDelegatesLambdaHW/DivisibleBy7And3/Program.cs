using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7And3
{
	class Program
	{
		public static void Main()
		{
			var numbers = new[] { 1, 3, 5, 7, 21 };
			Console.WriteLine("Array:");
			Console.WriteLine(string.Join(", ", numbers));

			Console.WriteLine("By lambda: ");
			PrintByLambda(numbers);

			Console.WriteLine("By query: ");
			PrintByQuery(numbers);
		}

		public static void PrintByLambda(int[] arr)
		{
			var result = arr.Where(n => n % 3 == 0 && n % 7 == 0);

			Console.WriteLine(string.Join(", ", result));
		}

		public static void PrintByQuery(int[] arr)
		{
			var result =
				from number in arr
				where number % 3 == 0 && number % 7 == 0
				select number;

			Console.WriteLine(string.Join(", ", result));
		}
	}
}
