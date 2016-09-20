using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
	public static class IEnumerableExtensions
	{
		public static T Sum<T>(this IEnumerable<T> enumerable)
		{
			dynamic sum = 0;

			foreach (var element in enumerable)
			{
				sum += element;
			}

			return sum;
		}

		public static T Product<T>(this IEnumerable<T> enumerable)
		{
			dynamic Prod = 1;

			foreach (var element in enumerable)
			{
				Prod *= element;
			}

			return Prod;
		}

		public static T Min<T>(this IEnumerable<T> enumerable)
			where T : IComparable<T>
		{
			T result = enumerable.First();

			foreach (var element in enumerable)
			{
				if (result.CompareTo(element) > 0)
				{
					result = element;
				}
			}

			return result;
		}

		public static T Max<T>(this IEnumerable<T> enumerable)
			where T : IComparable<T>
		{
			T result = enumerable.First();

			foreach (var element in enumerable)
			{
				if (result.CompareTo(element) < 0)
				{
					result = element;
				}
			}

			return result;
		}

		public static T Average<T>(this IEnumerable<T> enumerable)
		{
			return (dynamic)enumerable.Sum() / enumerable.Count();
		}
	}
}
