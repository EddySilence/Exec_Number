using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//題目：找出數值區間內的所有質數
			int numberStar = 5;
			int numberENd = 100;
			double number = 0;

			for (int i = numberStar; i <= numberENd ; i++)
			{
				number = Math.Sqrt(i);
				for (int k = 2; k <= number; k++)
				{
					if (i % k == 0)
					{
						Console.WriteLine($"{i}不是質數");
						break;
					}
					else if(k == Math.Floor(number))
					{
						Console.WriteLine($"{i}是質數");
					}
				}
			}

		}
	}
}
