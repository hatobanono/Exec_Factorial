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
			Console.Write("請輸入數字: ");
			string input = Console.ReadLine();
			int i = 1;

			for (int k = Convert.ToInt32(input); k > 0; k--) 
			{
				i *= k;
			}

			Console.WriteLine($"{input}的乘積為{i}");

		}
	}
}
