using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Timer
{
	class Program
	{
		static void Main(string[] args)
		{
			Execute(PrintHello, 1);
		}

		private static void Execute(Action action, int seconds)
		{
			while (true)
			{
				action();

				Thread.Sleep(seconds * 1000);
			}
		}

		private static void PrintHello()
		{
			Console.WriteLine("Hello!");
		}
	}
}
