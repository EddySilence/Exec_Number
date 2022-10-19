using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：判斷某數值是不是質數
			Console.WriteLine("輸入數字");
			String input = Console.ReadLine();
			bool Ints = int.TryParse(input, out int result);
			double number = Math.Sqrt(result);
			Console.WriteLine(number);

			for (int i = 2; i <= number; i++)
			{
				if (result % i == 0)
				{
					Console.WriteLine("不是質數");
					return;
				}
			}

			//Console.WriteLine("是質數");
		}
	}
}
