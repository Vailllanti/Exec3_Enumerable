using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var items = Enumerable.Range(1, 10);
			
			foreach (var item in items)
			{ 
				Console.WriteLine(item); 
			}

			Console.WriteLine();

			var item2 =Enumerable.Range(10, 6);

			foreach (var item in item2)
			{
				Console.WriteLine(item);
			}



		}
	}
}
