using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] newArray = new int[10] {45, 85, 64, 75, 15, 36, 48, 71, 19, 61};

			int minimunValue = GetMinimunValue(newArray);
			double averageValue = GetAverageValue(newArray);
			int maximunValue = GetMaximunValue(newArray);

			Console.Write("The array elements are: ");
			for (int i = 0; i < newArray.Length; i++)
			{
				Console.Write(newArray[i] + " ");
			}

			Console.WriteLine("\n\nThe minimun value of the array is: " + minimunValue);
			Console.WriteLine("The average value of the array is: " + averageValue);
			Console.WriteLine("The maximun value of the array is: " + maximunValue);

			Console.ReadLine();
		}

		public static int GetMaximunValue (int[] theArray)
		{
			int result = 0;

			result = theArray.Max();

			return result;
		}

		public static int GetMinimunValue(int[] theArray)
		{
			int result = 0;

			result = theArray.Min();

			return result;
		}

		public static double GetAverageValue(int[] theArray)
		{
			double result = 0;

			result = theArray.Average();

			return result;
		}
	}
}
