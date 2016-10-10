using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the first factor: ");
			int factor1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the second factor: ");
			int factor2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("The following is your multiplication table: ");

			int result = 0;

			for (int i = 1; i <= factor1; i++)
			{
				for (int j = 1; j <= factor2; j++)
				{
					result = i * j;
					Console.WriteLine("{0} x {1} = " + result, i, j);
				}
			  Console.WriteLine("\n");
			}
		  Console.ReadLine();
		}
	}
}
